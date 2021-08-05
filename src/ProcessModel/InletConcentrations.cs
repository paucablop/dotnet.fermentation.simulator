using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public record InletConcentrations : ICompounds
    {
        public double Glucose { get; set; }
        public double Furfural { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public InletConcentrations()
        {
            Glucose = 0.5;
            Furfural = 0.5;
            Ethanol = 0.0;
            Biomass = 0.0;
        }

        public void InletConcentratrionsAsVector()
        {
        }

    }
}