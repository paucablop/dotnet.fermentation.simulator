using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;

namespace Yeast.Kinetic.Model
{
    [PublicAPI]
    public record GlucoseMonod : ISimpleMonod
    {
        public double MaxGrowthRate { get; init; }
        public double AffinityConstant { get; init; }

        public GlucoseMonod()
        {
            MaxGrowthRate = 1.0;
            AffinityConstant = 0.5;
        }
    }
}