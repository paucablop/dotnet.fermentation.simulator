using Fermentation.Kinetic.Interfaces;
using Fermentation.Kinetic.Models;
using JetBrains.Annotations;
using MathNet.Numerics.Distributions;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model

{
    [PublicAPI]
    public record GlucoseUptake : IMonodInhibition
    {
        public double MaxUptakeRate { get; set; }
        public double AffinityConstant { get; set; }
        public double InhibitionConstant { get; set; }

        public GlucoseUptake()
        {
            MaxUptakeRate = Normal.Sample(1.0, 0.01);
            AffinityConstant = Normal.Sample(0.5, 0.005);
            InhibitionConstant = Normal.Sample(100, 1);
        }

        public double Calculate(double glucoseConcentration)
        {
            return UptakeModels.MonodSubstrateInhibition(glucoseConcentration, MaxUptakeRate, AffinityConstant,
                InhibitionConstant);
        }
    }
}
