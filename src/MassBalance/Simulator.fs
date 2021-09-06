namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Mass.Balance
open MathNet.Numerics.LinearAlgebra

module Simulator =

    let Run (initialConditions: Vector<float>, startTime: float, endTime: float, timeSteps: int) =
        let f =
            System.Func<float, Vector<float>, Vector<float>>
                (fun time -> Calculator.StateVariable)

        MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(initialConditions, startTime, endTime, timeSteps, f)
