namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Kinetic.Interfaces
open Fermentation.Kinetic.Models

module KineticRates =
    let GlucoseUptakeRate (glucoseConcentration: float, glucoseUptakeModel: ISimpleMonod) =
        let glucoseUptake =
            MonodModels.SimpleMonod(
                glucoseConcentration,
                glucoseUptakeModel.MaxGrowthRate,
                glucoseUptakeModel.AffinityConstant
            )
        glucoseUptake
        
    let EthanolInhibition (ethanolConcentration: float, ethanolInhibitionModel: ISuddenProductInhibition) =
        let ethanolInhibition =
            ProductInhibition.SuddenInhibition(
                ethanolConcentration,
                ethanolInhibitionModel.InhibitionConstant,
                ethanolInhibitionModel.InhibitionExponent
                )
        ethanolInhibition
