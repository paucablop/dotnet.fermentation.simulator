using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public class InletConcentrations : ICompounds
    {
        public InletConcentrations(Vector<double> inletConcentration)
        {
            Glucose = inletConcentration[0];
            Furfural = inletConcentration[1];
            Ethanol = inletConcentration[2];
            Biomass = inletConcentration[3];
        }
        public double Glucose { get; set; }
        public double Furfural { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
    }
}