namespace Fermentation.Simulator.Mass.Balance

open MathNet.Numerics.LinearAlgebra

module Generation =
    let stoichionometricMatrix = Matrix.Build.Dense(2, 4, 0.0)
    stoichionometricMatrix.[0, 0] <- -1.0
    stoichionometricMatrix.[0, 1] <- 0.51
    stoichionometricMatrix.[0, 2] <- 0.49
    stoichionometricMatrix.[0, 3] <- 0.0
    stoichionometricMatrix.[1, 3] <- -1.0

    let Calculate (kineticRates: Vector<float>) =
        stoichionometricMatrix.Transpose() * kineticRates
