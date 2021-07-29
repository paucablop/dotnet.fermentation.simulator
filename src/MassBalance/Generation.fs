namespace Fermentation.Simulator.Mass.Balance

open MathNet.Numerics.LinearAlgebra
open Yeast.Kinetic.Model

module Generation =
    let BuildStoichiometricMatrix () =
        let stoichionometricMatrix = Matrix.Build.Dense(2, 2, 0.0)
        stoichionometricMatrix.[0, 0] <- -1.0
        stoichionometricMatrix.[0, 1] <- 0.5
        stoichionometricMatrix

    
    let DifferentialEquationsSystem (concentrationsVector: Vector<float>) =
        let monodRate = KineticRates.GlucoseUptakeRate(concentrationsVector.[0],GlucoseMonod())
        let stoichiometricMatrix = BuildStoichiometricMatrix()

        let glucoseRate =
            monodRate
            * stoichiometricMatrix.[0, 0]
            * concentrationsVector.[1]

        let biomassRate =
            monodRate
            * stoichiometricMatrix.[0, 1]
            * concentrationsVector.[1]

        [glucoseRate; biomassRate]
            |> vector