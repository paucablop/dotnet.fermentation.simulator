using Fermentation.Kinetic.Interfaces;
using Fermentation.Kinetic.Models;
using JetBrains.Annotations;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model
{
    [PublicAPI]
    public class EthanolInhibitsGluocse : ISuddenInhibition
    {
        public double InhibitionConstant { get; set; }
        public double ExponentialConstant { get; set; }

        public EthanolInhibitsGluocse()
        {
            InhibitionConstant = 100.0;
            ExponentialConstant = 0.5;
        }

        public double Calculate(double ethanolConcentration)
        {
            return Inhibition.SuddenInhibition(ethanolConcentration, InhibitionConstant, ExponentialConstant );
        }
    }
}
