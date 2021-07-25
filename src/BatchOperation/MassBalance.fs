namespace BatchOperation

open System
open Fermentation.Simulator.KineticModels
open MathNet.Numerics.LinearAlgebra
open MathNet.Numerics.LinearAlgebra
open MathNet.Numerics.LinearAlgebra

module MassBalanance =
    let BuildStoichiometricMatrix () =
        let stoichionometricMatrix = Matrix.Build.Dense(2, 2, 0.0)
        stoichionometricMatrix.[0, 0] <- -1.0
        stoichionometricMatrix.[0, 1] <- 0.5
        stoichionometricMatrix

    let CalculateRates (concentrationsVector: Vector<float>) =
        let calculatedRates =
            MonodModels.SimpleMonod(concentrationsVector.[0], 1.0, 1.0)

        calculatedRates

    let DifferentialEquationsSystem (concentrationsVector: Vector<float>) =
        let monodRate = CalculateRates(concentrationsVector)
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
                    
