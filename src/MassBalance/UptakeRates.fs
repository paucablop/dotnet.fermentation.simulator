namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Kinetic.Models
open Fermentation.Simulator.Interfaces
open Fermentation.Simulator.Yeast.Anaerobic.Model
open MathNet.Numerics.LinearAlgebra

module UptakeRates =

    let Calculate (stateVariables: IStateVariables) =
        let glucoseRate =
            UptakeModels.MonodSubstrateInhibition(stateVariables.Glucose, GlucoseMonodSubstrateInhibition())
            * Inhibition.SuddenInhibition(stateVariables.Ethanol, EthanolInhibition())
            * Inhibition.InverseInhibition(stateVariables.Furfural, FurfuralInhibition())

        let furfuralRate =
            UptakeModels.Monod(stateVariables.Furfural, FurfuralMonod())

        [| glucoseRate; furfuralRate |]
        |> Array.map (fun x -> x * stateVariables.Biomass)
        |> vector
