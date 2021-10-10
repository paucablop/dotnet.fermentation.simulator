namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Interfaces
open MathNet.Numerics.LinearAlgebra
open MathNet.Numerics.LinearAlgebra.Double

module DilutionRates =
    let Calculate (stateVariables: IStateVariables, inletConcentrations: IChemicalVariables) =

        let dilution =
            stateVariables.Flowrate / stateVariables.Volume

        let dilutionRatesVector =
            inletConcentrations.ChemicalVariablesVector()
                .Subtract(stateVariables.ChemicalVariablesVector())
                .Multiply(dilution)

        dilutionRatesVector
