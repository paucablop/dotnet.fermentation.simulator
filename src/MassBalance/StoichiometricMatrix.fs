namespace Fermentation.Simulator.Mass.Balance.Stoichiometry

open Fermentation.Simulator.Yeast.Anaerobic.Model.YieldCoefficients
open MathNet.Numerics.LinearAlgebra

type StoichiometricMatrix () =
    member this.YeastYieldCoefficients = YeastYieldCoefficients()
    member this.Matrix() =
        let stoichiometricMatrix =
            Matrix<double>.Build.DenseDiagonal (3, 1, -1.0)
        stoichiometricMatrix.[1, 0] <- this.YeastYieldCoefficients.GlucoseEthanol
        stoichiometricMatrix.[2, 0] <- this.YeastYieldCoefficients.GlucoseBiomass
        stoichiometricMatrix
