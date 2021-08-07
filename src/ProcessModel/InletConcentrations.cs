using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public record InletConcentrations : IChemicalVariables
    {
        public double Glucose { get; set; }
        public double Furfural { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public InletConcentrations()
        {
            Glucose = 4.0;
            Furfural = 1.5;
            Ethanol = 0.0;
            Biomass = 0.0;
        }

        public Vector<double> ToVector()
        {
            var variables =
                new[]
                {
                    Glucose,
                    Furfural,
                    Ethanol,
                    Biomass
                };
            return Vector.Build.DenseOfArray(variables);
        }
    }
}
