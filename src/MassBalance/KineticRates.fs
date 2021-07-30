namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Kinetic.Models
open Yeast.Kinetic.Model

module KineticRates =

    let Glucose (glucoseConcentration: float, ethanolConcentration: float) =
        MonodModels.SimpleMonod(glucoseConcentration, GlucoseMonod())
        * ProductInhibition.SuddenInhibition(ethanolConcentration, EthanolInhibition())
