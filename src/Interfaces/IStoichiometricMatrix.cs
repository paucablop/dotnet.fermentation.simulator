using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IStoichiometricMatrix
    {
        Matrix<double> StoichiometricMatrix { get; set; }
    }
}