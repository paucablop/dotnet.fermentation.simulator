using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;

namespace Yeast.Kinetic.Model
{
    [PublicAPI]
    public record FurfuralMonod : IMonod
    {
        public double MaxUptakeRate { get; init; }
        public double AffinityConstant { get; init; }

        public FurfuralMonod()
        {
            MaxUptakeRate = 0.01;
            AffinityConstant = 2.0;
        }
    }

    [PublicAPI]
    public record FurfuralInhibition : IInverseInhibition
    {
        public double InhibitionConstant { get; init; }

        public FurfuralInhibition()
        {
            InhibitionConstant = 5.0;
        }
    }
}