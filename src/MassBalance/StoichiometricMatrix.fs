namespace Fermentation.Simulator.Mass.Balance

open MathNet.Numerics.LinearAlgebra

module StoichiometricMatrix =
    let Build () =
        let stoichionometricMatrix = Matrix.Build.Dense(1, 3, 0.0)
        stoichionometricMatrix.[0, 0] <- -1.0
        stoichionometricMatrix.[0, 1] <- 0.51
        stoichionometricMatrix.[0, 2] <- 0.49
        stoichionometricMatrix

    
    