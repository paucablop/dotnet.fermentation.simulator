namespace Fermentation.Simulator.InhibitionModels

module CompetitiveInhibition =
    let InhibitionFator (inhibitorConcentration : float, inhibitionConstant : float) =
        1.0 / (1.0 + inhibitorConcentration / inhibitionConstant)