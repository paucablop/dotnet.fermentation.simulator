namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Yeast.Anaerobic.Model
open MathNet.Numerics.LinearAlgebra

module KineticRates =
    let stoichiometricMatrix = YieldCoefficients.StoichiometricMatrix();
    let Calculate (kineticRates: Vector<float>) =
        stoichiometricMatrix * kineticRates
