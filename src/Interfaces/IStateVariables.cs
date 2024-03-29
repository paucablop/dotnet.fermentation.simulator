﻿using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IStateVariables : IChemicalVariables, IProcessVariables
    {
        public Vector<double> StateVariablesVector();
    }
}