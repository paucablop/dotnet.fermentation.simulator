using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public class CompoundRates : ICompounds
    {
        public double Glucose { get; set; }
        public double Furfural { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public CompoundRates(Vector<double> compoundRates)
        {
            Glucose = compoundRates[0];
            Furfural = compoundRates[1];
            Ethanol = compoundRates[2];
            Biomass = compoundRates[3];
        } }
}