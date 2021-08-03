﻿using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public class StateVariables : IStateVariables
    {
        public double Glucose { get; set; }
        public double Furfural { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public double FlowRate { get; set; }
        public double Volume { get; set; }
        public StateVariables(Vector<double> stateVariablesVector)
        {
            Glucose = stateVariablesVector[0];
            Furfural = stateVariablesVector[1];
            Ethanol = stateVariablesVector[2];
            Biomass = stateVariablesVector[3];
            FlowRate = stateVariablesVector[4];
            Volume = stateVariablesVector[5];
        }



    }
}