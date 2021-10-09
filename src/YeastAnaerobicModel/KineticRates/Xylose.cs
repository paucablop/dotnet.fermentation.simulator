using Fermentation.Kinetic.Interfaces;
using Fermentation.Kinetic.Models;
using JetBrains.Annotations;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model.KineticRates

{
    [PublicAPI]
    public record XyloseUptake : IMonodInhibition
    {
        public double MaxUptakeRate { get; set; }
        public double AffinityConstant { get; set; }
        public double InhibitionConstant { get; set; }

        public XyloseUptake()
        {
            MaxUptakeRate = 1.0;
            AffinityConstant = 0.5;
            InhibitionConstant = 100;
        }

        public double Calculate(double xyloseConcentration)
        {
            return UptakeModels.MonodSubstrateInhibition(xyloseConcentration, MaxUptakeRate, AffinityConstant,
                InhibitionConstant);
        }
    }
}