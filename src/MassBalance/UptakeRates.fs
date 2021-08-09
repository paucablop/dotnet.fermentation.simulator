namespace Fermentation.Simulator.Mass.Balance

open System
open Fermentation.Kinetic.Models
open Fermentation.Simulator.Interfaces
open Fermentation.Simulator.Yeast.Anaerobic.Model
open MathNet.Numerics.LinearAlgebra

module UptakeRates =
    let private ethanolInhibitionConstants =
        EthanolInhibition(randomize=false)
    let private furfuralInhibitionConstants =
        FurfuralInhibition(randomize=false)
    let private glucoseMonodUptake =
        GlucoseMonodSubstrateInhibition()
    let private furfuralMonodUptake =
        FurfuralMonod(randomize=false)

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
