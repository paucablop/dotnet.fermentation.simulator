namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Interfaces
open Fermentation.Simulator.Yeast.Anaerobic.Model
open Fermentation.Simulator.Yeast.Anaerobic.Model
open MathNet.Numerics.LinearAlgebra

module UptakeRates =
    let private glucoseUptake =
        GlucoseUptake() 
    let private ethanolInhibitsGluocse =
        EthanolInhibitsGluocse()

    let Calculate (stateVariables: IStateVariables) =
        let glucoseRate =
            glucoseUptake.Calculate(stateVariables.Glucose) *
            ethanolInhibitsGluocse.Calculate(stateVariables.Ethanol)

            
        [| glucoseRate |]
        |> Array.map (fun x -> x * stateVariables.Biomass)
        |> vector
