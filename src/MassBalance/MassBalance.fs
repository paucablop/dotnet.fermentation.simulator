namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Mass.Balance.Stoichiometry
open Fermentation.Simulator.Process.Model
open Fermentation.Simulator.ProcessRates
open Fermentation.Simulator.Yeast.Anaerobic.Model.YeastUptakeRates
open MathNet.Numerics.LinearAlgebra
open Variables
open VectorOperations

type MassBalance() =
    member this.ProcessConditions = ProcessConditions()
    member this.InitialConditions = InitialConditions()
    member this.InletConcentrations = InletConcentrations()
    member this.StoichiometricMatrix = StoichiometricMatrix().Matrix()
    member this.YeastUptakeRates = YeastUptakeRates()


    member this.Calculate(stateVariablesVector: Vector<float>) =
        
        let stateVariables = stateVariablesVector |> StateVariables

        /// Evaluate flowrate
        stateVariables.Flowrate <-
            if stateVariables.Volume >= this.ProcessConditions.Volume then 0.0 
            else stateVariables.Flowrate
        
        /// Calculate rates of process variables 
        let processVariablesRates =
            (stateVariables, this.ProcessConditions)
            |> ProcessRates.Calculate

        /// Calculate the dilution rates of the chemical variables
        let dilutionRates =
            (stateVariables, this.InletConcentrations)
            |> DilutionRates.Calculate
        
        /// Calculate the kinetic rates
        let kineticRates =
            (stateVariables, this.YeastUptakeRates)
            |> UptakeRates.Calculate
            |> this.StoichiometricMatrix.Multiply

        let stateVariablesRates =
            (kineticRates.Add(dilutionRates), processVariablesRates)
            |> VectorOperations.Append

        stateVariablesRates
