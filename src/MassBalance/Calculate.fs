namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Process.Model
open MathNet.Numerics.LinearAlgebra

module Calculate =
    let DifferentialEquations (stateVariablesVector: Vector<float>) =

        let stateVariables = stateVariablesVector |> StateVariables

        let inletCompounds = stateVariables |> Inlet.Calculate

        let kineticRates =
            stateVariables
            |> UptakeRates.Calculate
            |> KineticRates.Calculate

        let accumulationCompounds = inletCompounds + kineticRates

        accumulationCompounds
