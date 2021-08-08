using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.Distributions;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model
{
    [PublicAPI]
    public record FurfuralMonod : IMonod
    {
        public double MaxUptakeRate { get; set; }
        public double AffinityConstant { get; set; }

        public FurfuralMonod(bool randomize)
        {
            if (!randomize)
            {
                MaxUptakeRate = 0.01;
                AffinityConstant = 2.0;
            }
            else
            {
                MaxUptakeRate = Normal.Sample(0.01, 0.001);
                AffinityConstant = Normal.Sample(2.0, 0.2);
            }

        }
    }

    [PublicAPI]
    public record FurfuralInhibition : IInverseInhibition
    {
        public double InhibitionConstant { get; set; }

        public FurfuralInhibition(bool randomize)
        {
            InhibitionConstant = !randomize ? 5.0 : Normal.Sample(5.0, 0.5);
        }
    }
}
