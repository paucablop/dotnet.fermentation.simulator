using Fermentation.Kinetic.Interfaces;
using Fermentation.Kinetic.Models;
using JetBrains.Annotations;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model
{
    [PublicAPI]
    public record FurfuralUptake : IMonod
    {
        public double MaxUptakeRate { get; set; }
        public double AffinityConstant { get; set; }
        
        public FurfuralUptake()
        {
            MaxUptakeRate = 0.01;
            AffinityConstant = 2.0;
        }
        public double Calculate(double furfuralConcentration)
        {
            return UptakeModels.Monod(furfuralConcentration, MaxUptakeRate, AffinityConstant);
        }
    }

    [PublicAPI]
    public record FurfuralInhibitsGlucose : IInverseInhibition
    {
        public double InhibitionConstant { get; set; }

        public FurfuralInhibitsGlucose()
        {
            InhibitionConstant = 5.0;
        }

        public double Calculate(double furfuralConcentration)
        {
            return Inhibition.InverseInhibition(furfuralConcentration, InhibitionConstant);
        }     
    }
}
