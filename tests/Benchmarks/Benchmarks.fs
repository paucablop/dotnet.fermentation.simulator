module Benchmarks 

open BenchmarkDotNet.Attributes
open Fermentation.Simulator.Mass.Balance
open MathNet.Numerics.LinearAlgebra

[<MemoryDiagnoser>]
type Benchmarks () =
    let initialConditions = Vector<double>.Build.Dense(6, 1.0)
    let startTime = 0.0
    let endTime = 10.0
    let timeSteps = 100
    let stateVariables = initialConditions |> StateVariables
    let kineticRates = stateVariables |> UptakeRates.Calculate 
    [<Benchmark>]
    member this.StateVariable () =
        initialConditions |> StateVariables

    [<Benchmark>]
    member this.UptakeRatesCalculate() =
        UptakeRates.Calculate(stateVariables)
        
    [<Benchmark>]
    member this.KineticRatesCalculate() =
        KineticRates.Calculate(kineticRates)
        
    [<Benchmark>]
    member this.ProgramSolve() =
        Simulator.Run(initialConditions, startTime, endTime, timeSteps)
        


   


