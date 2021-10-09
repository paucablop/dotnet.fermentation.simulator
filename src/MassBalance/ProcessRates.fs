namespace Fermentation.Simulator.ProcessRates

open Fermentation.Simulator.Interfaces
open Variables


module ProcessRates =
    let Calculate (stateVariables: IStateVariables, processConditions: IProcessVariables) =
        let processRates = ProcessVariables()
        processRates.Flowrate <- 0.0
        
        processRates.Volume <-
            if stateVariables.Volume >= processConditions.Volume then 0.0
            else stateVariables.Flowrate
            
        processRates.ProcessVariablesVector()