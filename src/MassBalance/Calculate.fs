namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Process.Model
open MathNet.Numerics.LinearAlgebra
open MathNet.Numerics.LinearAlgebra

module Calculate =
    let DifferentialEquations (stateVariablesVector: Vector<float>) =

        let stateVariables =
            stateVariablesVector
            |> StateVariables
        
        let flowRateAndVolume =
            stateVariables
            |> Inlet.CalculateFlowRateAndVolume
        
        let inletCompounds =
            stateVariables
            |> Inlet.CalculateCompounds

        let kineticRates =
            stateVariables
            |> UptakeRates.Calculate
            |> KineticRates.Calculate
            |> (+) inletCompounds
        
        let differentialEquations = Vector.Build.Dense(6, 0.0)

        differentialEquations.[0] <- kineticRates.[0]
        differentialEquations.[1] <- kineticRates.[1]
        differentialEquations.[2] <- kineticRates.[2]
        differentialEquations.[3] <- kineticRates.[3]
        differentialEquations.[4] <- flowRateAndVolume.[0]
        differentialEquations.[5] <- flowRateAndVolume.[1]

        differentialEquations
