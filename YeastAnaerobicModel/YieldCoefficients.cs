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

        public static Matrix<double> StoichiometricMatrix()
        {
            var stoichiometricMatrix = Matrix.Build.DenseDiagonal(2, 4, -1.0);

                stoichiometricMatrix[0, 2] = _glucoseEthanol + CalculateLogNormalDistributionFactor();
                stoichiometricMatrix[0, 3] = _glucoseBiomass + CalculateLogNormalDistributionFactor();
                return stoichiometricMatrix.Transpose();
        }

        private static double CalculateLogNormalDistributionFactor()
        {
            return (1 - LogNormal.Sample(0.01, 0.01));
        }
    }
}
