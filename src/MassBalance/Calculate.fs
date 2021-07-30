namespace Fermentation.Simulator.Mass.Balance

open MathNet.Numerics.LinearAlgebra

module Calculate  =
    let DifferentialEquations (concentrationsVector: Vector<float>) =
            
            let glucoseConcentration = concentrationsVector.[0]
            let ethanolConcentration = concentrationsVector.[1]
            let biomassConcentration = concentrationsVector.[2]
            
            let glucoseRate = KineticRates.Glucose(glucoseConcentration, ethanolConcentration)
            
            let stoichiometricMatrix = StoichiometricMatrix.Build()
            let rates = stoichiometricMatrix.Multiply(glucoseRate) * biomassConcentration
            rates.Row(0)
