using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model
{
    [PublicAPI]
    public static class YieldCoefficients
    {
        private static double _glucoseEthanol = 0.51;
        private static double _glucoseBiomass = 0.49;

        public static Matrix<double> StoichiometricMatrix(bool randomize)
        {
            var stoichiometricMatrix = Matrix.Build.DenseDiagonal(2, 4, -1.0);
            if (!randomize)
            {
                stoichiometricMatrix[0, 2] = _glucoseEthanol + 1 - LogNormal.Sample(0.01, 0.01);
                stoichiometricMatrix[0, 3] = _glucoseBiomass + 1 - LogNormal.Sample(0.01, 0.01);
            }
            else
            {
                stoichiometricMatrix[0, 2] = Normal.Sample(_glucoseEthanol,0.005);
                stoichiometricMatrix[0, 3] = Normal.Sample(_glucoseBiomass, 0.005);
            }
            return stoichiometricMatrix.Transpose();
        }
    }
}
