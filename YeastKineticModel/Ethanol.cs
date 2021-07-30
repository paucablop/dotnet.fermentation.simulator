using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;

namespace Yeast.Kinetic.Model
{
    [PublicAPI]
    public record EthanolInhibition : ISuddenInhibition
    {
        public double InhibitionConstant { get; init; }
        public double ExponentialConstant { get; init; }

        public EthanolInhibition()
        {
            InhibitionConstant = 10.0;
            ExponentialConstant = 0.5;
        }
    }
}