using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;

namespace Yeast.Kinetic.Model
{
    [PublicAPI]
    public record GlucoseMonodSubstrateInhibition : IMonodInhibition
    {
        public double MaxUptakeRate { get; init; }
        public double AffinityConstant { get; init; }
        public double InhibitionConstant { get; init; }

        public GlucoseMonodSubstrateInhibition()
        {
            MaxUptakeRate = 1.0;
            AffinityConstant = 0.5;
            InhibitionConstant = 0.5;
        }
    }
}