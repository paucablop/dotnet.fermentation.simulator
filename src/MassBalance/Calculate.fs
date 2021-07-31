namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Mass.Balance
open MathNet.Numerics.LinearAlgebra
open Fermentation.Simulator.State.Variables

module Calculate =
    let DifferentialEquations (stateVariablesVector: Vector<float>) =
        stateVariablesVector
        |> StateVariables
        |> KineticRates.Calculate
        |> Generation.Calculate
