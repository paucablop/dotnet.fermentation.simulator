namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Interfaces
open Variables

module UptakeRates =
    let Calculate (stateVariables: IStateVariables, yeastUptakeRates: IYeastModel) =
        let uptakeRates = IndependentChemicalVariables()

        uptakeRates.Glucose <- yeastUptakeRates.GlucoseUptakeRate(stateVariables)
        uptakeRates.IndependentChemicalVariablesVector()
