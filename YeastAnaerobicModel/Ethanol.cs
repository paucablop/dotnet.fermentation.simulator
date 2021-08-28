using Fermentation.Kinetic.Interfaces;
using Fermentation.Kinetic.Models;
using JetBrains.Annotations;
using MathNet.Numerics.Distributions;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model
{
    [PublicAPI]
    public class EthanolInhibitsGluocse : ISuddenInhibition
    {
        public double InhibitionConstant { get; set; }
        public double ExponentialConstant { get; set; }

        public EthanolInhibitsGluocse()
        {
            InhibitionConstant = Normal.Sample(20.0, 0.2);
            ExponentialConstant = Normal.Sample(0.5, 0.005);
        }

        public double Calculate(double ethanolConcentration)
        {
            return Inhibition.SuddenInhibition(ethanolConcentration, InhibitionConstant, ExponentialConstant );
        }
    }
}
