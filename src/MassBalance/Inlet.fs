namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Interfaces
open Fermentation.Simulator.Process.Model
open MathNet.Numerics.LinearAlgebra

module Inlet =

    let ConcentrationDifference (compoundConcentrationTank: float, compoundConcentrationInlet: float) =
        compoundConcentrationTank
        - compoundConcentrationInlet

    let CalculateCompounds (stateVariables: IStateVariables) =

        let glucoseInOut =
            ConcentrationDifference(stateVariables.Glucose, InletConcentrations().Glucose)

        let furfuralInOut =
            ConcentrationDifference(stateVariables.Furfural, InletConcentrations().Furfural)

        let ethanolInOut =
            ConcentrationDifference(stateVariables.Ethanol, InletConcentrations().Ethanol)

        let biomassInOut =
            ConcentrationDifference(stateVariables.Biomass, InletConcentrations().Biomass)

        [| glucoseInOut
           furfuralInOut
           ethanolInOut
           biomassInOut |]
        |> Array.map
            (fun x ->
                x * stateVariables.FlowRate
                / stateVariables.Volume)
        |> vector

    let CalculateFlowRateAndVolume (stateVariables: IStateVariables) =
        let flowRate = 0.0
        let volume = stateVariables.FlowRate

        [| flowRate; volume |] |> vector
