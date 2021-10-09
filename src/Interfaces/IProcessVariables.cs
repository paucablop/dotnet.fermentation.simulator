using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IProcessVariables
    {
        double Flowrate { get; set; }
        double Volume { get; set; }
        public Vector<double> ProcessVariablesVector();
    }
}