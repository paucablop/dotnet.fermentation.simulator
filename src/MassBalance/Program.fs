namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Mass.Balance
open MathNet.Numerics.LinearAlgebra
open MathNet.Numerics.LinearAlgebra
open Plotly.NET

module Program =

    let Run (initialConditions: Vector<float>, startTime: float, endTime: float, timeSteps: int) =
        let f =
            System.Func<float, Vector<float>, Vector<float>>
                (fun time concentrationsVector -> Calculate.DifferentialEquations(concentrationsVector))

        let fermentationProfile =
            MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(initialConditions, startTime, endTime, timeSteps, f)

        fermentationProfile
