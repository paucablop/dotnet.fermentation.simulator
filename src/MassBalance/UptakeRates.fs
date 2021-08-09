namespace Fermentation.Simulator.Mass.Balance

open System
open Fermentation.Kinetic.Models
open Fermentation.Simulator.Interfaces
open Fermentation.Simulator.Yeast.Anaerobic.Model
open MathNet.Numerics.LinearAlgebra

module UptakeRates =
    let private ethanolInhibitionConstants =
        EthanolInhibition(randomize=true)
    let private furfuralInhibitionConstants =
        FurfuralInhibition(randomize=true)
    let private glucoseMonodUptake =
        GlucoseMonodSubstrateInhibition(randomize=true)
    let private furfuralMonodUptake =
        FurfuralMonod(randomize=true)

    let Calculate (stateVariables: IStateVariables) =
        let glucoseRate =
            UptakeModels.MonodSubstrateInhibition(stateVariables.Glucose, glucoseMonodUptake)
            * Inhibition.SuddenInhibition(stateVariables.Ethanol, ethanolInhibitionConstants)
            * Inhibition.InverseInhibition(stateVariables.Furfural, furfuralInhibitionConstants)

        let furfuralRate =
            UptakeModels.Monod(stateVariables.Furfural, furfuralMonodUptake)

        [| glucoseRate; furfuralRate |]
        |> Array.map (fun x -> x * stateVariables.Biomass)
        |> vector
