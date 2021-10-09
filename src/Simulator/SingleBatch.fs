namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Mass.Balance
open MathNet.Numerics.LinearAlgebra

module SingleBatch =
    let Run (initialConditions: Vector<float>, startTime: float, endTime: float, timeSteps: int) =
        let massBalanceModel = MassBalance()

        let f =
            System.Func<float, Vector<float>, Vector<float>>(fun time -> massBalanceModel.Calculate)

        MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(initialConditions, startTime, endTime, timeSteps, f)
