﻿namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Process.Model
open MathNet.Numerics.LinearAlgebra

module Calculate =
    let DifferentialEquations (stateVariablesVector: Vector<float>) =

        let stateVariables = stateVariablesVector |> StateVariables

        let flowRateAndVolume =
            stateVariables
            |> Inlet.CalculateFlowRateAndVolume

        let inletCompounds =
            stateVariables |> Inlet.CalculateCompounds

        let kineticRates =
            stateVariables
            |> UptakeRates.Calculate
            |> KineticRates.Calculate
            |> (+) inletCompounds

        (kineticRates, flowRateAndVolume)
            |> stateVariables.FromVectorsToVector
