using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IDependentChemicalVariables
    {
        double Ethanol { get; set; }
        double Biomass { get; set; }
        public Vector<double> DependentChemicalVariablesVector();
    }
}