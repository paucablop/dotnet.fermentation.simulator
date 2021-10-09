using JetBrains.Annotations;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model.YieldCoefficients
{
    [PublicAPI]
    public class YeastYieldCoefficients
    {
        public double GlucoseEthanol{ get; set; }
        public double GlucoseBiomass{ get; set; }
        
        public YeastYieldCoefficients()
        {
            GlucoseEthanol = 0.51;
            GlucoseBiomass = 0.49;
        }
    }
}
