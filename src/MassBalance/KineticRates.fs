namespace Fermentation.Simulator.Mass.Balance

open MathNet.Numerics.LinearAlgebra
open Fermentation.Simulator.Process.Model
module KineticRates =
    let stoichionometricMatrix =
        Matrix.Build.DenseDiagonal(2, 4, -1.0)        
    stoichionometricMatrix.[0, 2] <- 0.510
    stoichionometricMatrix.[0, 3] <- 0.490

    
    let Calculate (kineticRates: Vector<float>) =
        stoichionometricMatrix.Transpose() * kineticRates
