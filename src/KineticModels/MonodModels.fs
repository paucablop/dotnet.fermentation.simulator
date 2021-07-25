namespace Fermentation.Simulator.KineticModels

module MonodModels =
    let SimpleMonod (substrateConcentration: float, maxGrowthRate: float, affinityConstant: float) =
        maxGrowthRate * substrateConcentration
        / (affinityConstant + substrateConcentration)

    let MonodSubstrateInhibition
        (
            substrateConcentration: float,
            maxGrowthRate: float,
            affinityConstant: float,
            inhibitionConstant: float
        ) =
        maxGrowthRate * substrateConcentration
        / (affinityConstant
           + substrateConcentration
           + substrateConcentration ** 2.0 / inhibitionConstant)

    let MonodSubstrateCompetitiveInhibition
        (
            substrateConcentration: float,
            maxGrowthRate: float,
            affinityConstant: float,
            inhibitionConstant: float
        ) =
        maxGrowthRate
        / ((1.0 + affinityConstant / substrateConcentration)
           * (1.0 + substrateConcentration / inhibitionConstant))

    let MonodSubstrateNonCompetitiveInhibition
        (
            substrateConcentration: float,
            maxGrowthRate: float,
            affinityConstant: float,
            inhibitionConstant: float
        ) =
        maxGrowthRate * substrateConcentration
        / (affinityConstant
           * (1.0 + substrateConcentration / inhibitionConstant)
           + substrateConcentration)
