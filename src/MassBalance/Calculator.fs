﻿namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Process.Model
open MathNet.Numerics.LinearAlgebra

module Calculator =
    let StateVariable (stateVariablesVector: Vector<float>) =

        let stateVariables = stateVariablesVector |> StateVariables

        let physicalRates =
            stateVariables
            |> PhysicalVariablesRates.Calculate

        let dilutions =
            stateVariables
            |> Dilution.Calculate

        let chemicalRates =
            stateVariables
            |> UptakeRates.Calculate
            |> KineticRates.Calculate
            |> (+) dilutions

        (chemicalRates, physicalRates)
            |> stateVariables.AppendVectors
