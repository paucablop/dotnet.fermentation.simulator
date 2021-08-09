using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model

{
    [PublicAPI]
    public record GlucoseMonodSubstrateInhibition : IMonodInhibition
    {
        public double MaxUptakeRate { get; set; }
        public double AffinityConstant { get; set; }
        public double InhibitionConstant { get; set; }

        public GlucoseMonodSubstrateInhibition()
        {
            MaxUptakeRate = 1.0;
            AffinityConstant = 0.5;
            InhibitionConstant = 100.0;
        }
    }
}
