module Benchmarks 

open BenchmarkDotNet.Attributes
open Fermentation.Simulator.Mass.Balance
open Fermentation.Simulator.Mass.Balance
open Fermentation.Simulator.Mass.Balance.Stoichiometry
open Fermentation.Simulator.Process.Model
open Fermentation.Simulator.Yeast.Anaerobic.Model.YeastUptakeRates
open MathNet.Numerics.LinearAlgebra

[<MemoryDiagnoser>]
type Benchmarks () =
    let ProcessConditions = ProcessConditions()
    let InitialConditions = InitialConditions()
    let InletConcentrations = InletConcentrations()
    let StoichiometricMatrix = StoichiometricMatrix().Matrix()
    let YeastUptakeRates = YeastUptakeRates()
    let startTime = 0.0
    let endTime = 10.0
    let timeSteps = 100

    [<Benchmark>]
    member this.UptakeRatesCalculate() =
        UptakeRates.Calculate(InitialConditions, YeastUptakeRates)
        
    [<Benchmark>]
    member this.ProgramSolve() =
        SingleBatch.Run(InitialConditions.StateVariablesVector(), startTime, endTime, timeSteps)
        


   


