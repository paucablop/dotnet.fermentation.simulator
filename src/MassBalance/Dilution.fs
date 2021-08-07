namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Interfaces
open Fermentation.Simulator.Process.Model
open MathNet.Numerics.LinearAlgebra

module Dilution =
    let ConcentrationDifference (compoundConcentrationTank: float, compoundConcentrationInlet: float) =
        compoundConcentrationInlet
        - compoundConcentrationTank
    let Calculate (stateVariables: IStateVariables) =

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
                x * stateVariables.Flowrate
                / stateVariables.Volume)
        |> vector
