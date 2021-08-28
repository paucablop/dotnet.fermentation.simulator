namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Interfaces
open Fermentation.Simulator.Yeast.Anaerobic.Model
open MathNet.Numerics.LinearAlgebra

module UptakeRates =
    let private ethanolInhibitsGluocse =
        EthanolInhibitsGluocse()
    let private furfuralInhibitsGlucose =
        FurfuralInhibitsGlucose()
    let private glucoseUptake =
        GlucoseUptake()
    let private furfuralUptake =
        FurfuralUptake()

    let Calculate (stateVariables: IStateVariables) =
        let glucoseRate =
            glucoseUptake.Calculate(stateVariables.Glucose)
            * ethanolInhibitsGluocse.Calculate(stateVariables.Ethanol)
            * furfuralInhibitsGlucose.Calculate(stateVariables.Furfural)

        let furfuralRate =
            furfuralUptake.Calculate(stateVariables.Glucose)
            
        [| glucoseRate; furfuralRate |]
        |> Array.map (fun x -> x * stateVariables.Biomass)
        |> vector
