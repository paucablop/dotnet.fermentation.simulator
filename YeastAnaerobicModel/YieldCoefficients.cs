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
        private static double _xyloseEthanol = 0.30;
        private static double _xyloseBiomass = 0.15;

        public static Matrix<double> StoichiometricMatrix()
        {
            var stoichiometricMatrix = Matrix.Build.DenseDiagonal(3, 1, -1.0);
                stoichiometricMatrix[1, 0] = _glucoseEthanol;
                stoichiometricMatrix[2, 0] = _glucoseBiomass;
                return stoichiometricMatrix;
        }

        private static double CalculateLogNormalDistributionFactor()
        {
            return (1 - LogNormal.Sample(0.01, 0.01));
        }
    }
}
