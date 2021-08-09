using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.Distributions;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model

{
    [PublicAPI]
    public record GlucoseMonodSubstrateInhibition : IMonodInhibition
    {
        public double MaxUptakeRate { get; set; }
        public double AffinityConstant { get; set; }
        public double InhibitionConstant { get; set; }

        public GlucoseMonodSubstrateInhibition(bool randomize)
        {
            if (!randomize)
            {
                MaxUptakeRate = 1.0;
                AffinityConstant = 0.5;
                InhibitionConstant = 100.0;
            }
            else
            {
                MaxUptakeRate = Normal.Sample(1.0, 0.01);
                AffinityConstant = Normal.Sample(0.5, 0.005);
                InhibitionConstant = Normal.Sample(100, 1);
            }
        }
    }
}
