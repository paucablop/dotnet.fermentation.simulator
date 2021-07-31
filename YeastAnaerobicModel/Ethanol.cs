using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model
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