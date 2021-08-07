namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Process.Model
open MathNet.Numerics.LinearAlgebra

module Calculate =
    let DifferentialEquations (stateVariablesVector: Vector<float>) =

        let stateVariables = stateVariablesVector |> StateVariables

        let physicalRates =
            stateVariables
            |> PhysicalVariables.Calculate

        let dilutions =
            stateVariables
            |> Dilution.Calculate

        let chemicalRates =
            stateVariables
            |> UptakeRates.Calculate
            |> KineticRates.Calculate
            |> (+) dilutions

        (chemicalRates, physicalRates)
            |> stateVariables.FromVectorsToVector
