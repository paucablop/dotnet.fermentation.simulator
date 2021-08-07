using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model
{
    [PublicAPI]
    public static class YieldCoefficients
    {
        static double _glucoseEthanol = 0.51;
        static double _glucoseBiomass = 0.49;

        public static Matrix<double> StoichiometricMatrix()
        {
            var stoichiometricMatrix = Matrix.Build.DenseDiagonal(2, 4, -1.0);
            stoichiometricMatrix[0, 2] = _glucoseEthanol;
            stoichiometricMatrix[0, 3] = _glucoseBiomass;
            return stoichiometricMatrix.Transpose();
        }
    }
}
