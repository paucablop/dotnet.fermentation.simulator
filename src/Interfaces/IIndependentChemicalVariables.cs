using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IIndependentChemicalVariables
    {
        double Glucose { get; set; }
        public Vector<double> IndependentChemicalVariablesVector();
    }
}