namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Process.Model
open MathNet.Numerics.LinearAlgebra

module Calculate =
    let DifferentialEquations (stateVariablesVector: Vector<float>) =
        stateVariablesVector
        |> StateVariables
        |> KineticRates.Calculate
        |> Generation.Calculate
