using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model
{
    [PublicAPI]
    public record FurfuralMonod : IMonod
    {
        public double MaxUptakeRate { get; set; }
        public double AffinityConstant { get; set; }

        public FurfuralMonod()
        {
            MaxUptakeRate = 0.01;
            AffinityConstant = 2.0;
        }
    }

    [PublicAPI]
    public record FurfuralInhibition : IInverseInhibition
    {
        public double InhibitionConstant { get; set; }

        public FurfuralInhibition()
        {
            InhibitionConstant = 5.0;
        }
    }
}
