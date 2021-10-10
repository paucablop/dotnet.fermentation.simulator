namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Interfaces
open MathNet.Numerics.LinearAlgebra

module DilutionRates =
    let Calculate (stateVariables: IStateVariables, inletConcentrations: IChemicalVariables) =

        let dilution =
            stateVariables.Flowrate / stateVariables.Volume

        let tankConcentrationsVector = stateVariables.ChemicalVariablesVector()

        let inletConcentrationsVector =
            inletConcentrations.ChemicalVariablesVector()

        let dilutionRatesVector =
            inletConcentrationsVector
                .Subtract(tankConcentrationsVector)
                .Multiply(dilution)

        dilutionRatesVector
