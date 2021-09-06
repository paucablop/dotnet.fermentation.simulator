namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Interfaces
open MathNet.Numerics.LinearAlgebra

module PhysicalVariablesRates =
    let Calculate (stateVariables: IStateVariables) =
        let flowrateRate = 0.0
        let volumeRate = stateVariables.Flowrate
        [| flowrateRate; volumeRate |] |> vector
