namespace Fermentation.Simulation.Plotting

open MathNet.Numerics.LinearAlgebra
open Plotly.NET

module PlotFermentation =
    let Plot (fermentationProfile: Vector<float> array) =
        let time = [| 0.0 .. 99.0 |]

        let glucose =
            fermentationProfile |> Array.map (fun x -> x.[0])

        let furfural =
            fermentationProfile |> Array.map (fun x -> x.[1])

        let ethanol =
            fermentationProfile |> Array.map (fun x -> x.[2])

        let biomass =
            fermentationProfile |> Array.map (fun x -> x.[3])

        let flowrate =
            fermentationProfile |> Array.map (fun x -> x.[4])

        let volume =
            fermentationProfile |> Array.map (fun x -> x.[5])

        [ Chart.Line(time, glucose, Name="Glucose")
          Chart.Line(time, furfural, Name="Furfural")
          Chart.Line(time, ethanol, Name="Ethanol")
          Chart.Line(time, biomass, Name="Biomass")
          Chart.Line(time, flowrate, Name="Flowrate")
          Chart.Line(time, volume, Name="Volume") ]
        |> Chart.Combine
        |> Chart.Show
