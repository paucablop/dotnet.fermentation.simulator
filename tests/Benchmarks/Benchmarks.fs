module Benchmarks 

open BenchmarkDotNet.Attributes
open Fermentation.Simulator.Mass.Balance
open Fermentation.Simulator.Process.Model
open MathNet.Numerics.LinearAlgebra

[<MemoryDiagnoser>]
type Benchmarks () =
    let initialConditions = Vector<double>.Build.Dense(4, 1.0)
    let startTime = 0.0
    let endTime = 10.0
    let timeSteps = 100
    let stateVariables = initialConditions |> StateVariables
    let kineticRates = stateVariables |> KineticRates.Calculate 
    [<Benchmark>]
    member this.StateVariable () =
        initialConditions |> StateVariables

    [<Benchmark>]
    member this.KineticRatesCalculate() =
        KineticRates.Calculate(stateVariables)
        
    [<Benchmark>]
    member this.GenerationCalculate() =
        Generation.Calculate(kineticRates)
        
    [<Benchmark>]
    member this.ProgramSolve() =
        Program.Run(initialConditions, startTime, endTime, timeSteps)
        


   


