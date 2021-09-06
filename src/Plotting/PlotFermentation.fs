namespace Fermentation.Simulation.Plotting

open MathNet.Numerics
open MathNet.Numerics.LinearAlgebra
open Plotly.NET

module PlotFermentation =
    let Plot (fermentationProfile: Vector<float> array, startTime: float, endTime: float) =
        let time = Generate.LinearSpaced(fermentationProfile.Length, startTime, endTime)

        let glucose =
            fermentationProfile |> Array.map (fun x -> x.[0])

        let ethanol =
            fermentationProfile |> Array.map (fun x -> x.[1])

        let biomass =
            fermentationProfile |> Array.map (fun x -> x.[2])

        let flowrate =
            fermentationProfile |> Array.map (fun x -> x.[3])

        let volume =
            fermentationProfile |> Array.map (fun x -> x.[4])

        [ Chart.Line(time, glucose, Name="Glucose")
          Chart.Line(time, ethanol, Name="Ethanol")
          Chart.Line(time, biomass, Name="Biomass")
          Chart.Line(time, flowrate, Name="Flowrate")
          Chart.Line(time, volume, Name="Volume") ]
        |> Chart.Combine
        |> Chart.Show
