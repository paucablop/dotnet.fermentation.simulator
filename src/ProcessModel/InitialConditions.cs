using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public class InitialConditions : IStateVariables
    {
        public double Glucose { get; set; }
        public double Furfural { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public double Flowrate { get; set; }
        public double Volume { get; set; }

        public InitialConditions()
        {
            Glucose = 1.0;
            Furfural = 1.0;
            Ethanol = 1.0;
            Biomass = 1.0;
            Flowrate = 1.0;
            Volume = 1.0;
        }
    }
}