namespace Fermentation.Simulator.InhibitionModels

open System
open System.Runtime.InteropServices

module ProductInhibition =
    (*
    source : Dynamics of inhibition patterns during fermentation processes-Zea Mays and Sorghum Bicolor case study
    *)
    let LinearProductInhibition (productConcentration: float, inhibitionConstant: float) =
        1.0 - productConcentration * inhibitionConstant

    let ExponentialProductInhibition (productConcentration: float, inhibitionConstant: float) =
        Math.Exp(-productConcentration * inhibitionConstant)

    let SuddenProductInhibition
        (
            productConcentration: float,
            inhibitionConstant: float,
            [<Optional; DefaultParameterValue(1)>] inhibitionExponent: float
        ) =
        1.0
        - (productConcentration / inhibitionConstant)
          ** inhibitionExponent
