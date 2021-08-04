namespace Fermentation.Simulator.Mass.Balance

open Fermentation.Simulator.Process.Model
open MathNet.Numerics.LinearAlgebra
open MathNet.Numerics.LinearAlgebra

module Calculate =
    let DifferentialEquations (stateVariablesVector: Vector<float>) =

        let stateVariables = stateVariablesVector |> StateVariables

        let inletCompounds = stateVariables |> Inlet.Calculate

        let kineticRates =
            stateVariables
            |> UptakeRates.Calculate
            |> KineticRates.Calculate

        let accumulationCompounds = inletCompounds + kineticRates

        let accumulationFlowRate = 0.0


        let accumulationVolume = stateVariables.FlowRate

        let differentialEquations = Vector.Build.Dense(6, 0.0)

        differentialEquations.[0] <- accumulationCompounds.[0]
        differentialEquations.[1] <- accumulationCompounds.[1]
        differentialEquations.[2] <- accumulationCompounds.[2]
        differentialEquations.[3] <- accumulationCompounds.[3]
        differentialEquations.[4] <- accumulationFlowRate
        differentialEquations.[5] <- accumulationVolume

        differentialEquations
