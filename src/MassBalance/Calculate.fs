namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Process.Model
open MathNet.Numerics.LinearAlgebra

module Calculate =
    let DifferentialEquations (stateVariablesVector: Vector<float>) =

        let stateVariables = stateVariablesVector |> StateVariables
        let differentialStateVariables = DifferentialStateVariables()
        
        let flowRateAndVolume =
            stateVariables
            |> Inlet.CalculateFlowRateAndVolume
            |> differentialStateVariables.FlowRateAndVolumeFromVector
            
        let inletCompounds =
            stateVariables |> Inlet.CalculateCompounds

        stateVariables
        |> UptakeRates.Calculate
        |> KineticRates.Calculate
        |> (+) inletCompounds
        |> differentialStateVariables.CompoundsFromVector
        
        differentialStateVariables.ToVector()
