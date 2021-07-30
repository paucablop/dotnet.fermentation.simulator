namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Kinetic.Models
open MathNet.Numerics.LinearAlgebra
open StateVariables
open StateVariables
open Yeast.Kinetic.Model

module KineticRates =

    let Calculate (stateVariables: IStateVariables) =
        let glucoseRate =
            UptakeModels.MonodSubstrateInhibition(stateVariables.Glucose, GlucoseMonodSubstrateInhibition())
            * Inhibition.SuddenInhibition(stateVariables.Ethanol, EthanolInhibition())
            * Inhibition.InverseInhibition(stateVariables.Furfural, FurfuralInhibition())
            * stateVariables.Biomass

        let furfuralRate =
            UptakeModels.Monod(stateVariables.Furfural, FurfuralMonod())
            * stateVariables.Biomass

        [| glucoseRate; furfuralRate |] |> vector
