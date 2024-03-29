﻿using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IChemicalVariables : IIndependentChemicalVariables, IDependentChemicalVariables
    {
        public Vector<double> ChemicalVariablesVector();
    }
}