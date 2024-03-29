﻿using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public class InitialConditions : IStateVariables
    {
        public double Glucose { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public double Flowrate { get; set; }
        public double Volume { get; set; }

        public InitialConditions()
        {
            Glucose = 40.0;
            Ethanol = 0.0;
            Biomass = 0.1;
            Flowrate = 0.5;
            Volume = 1.0;
        }

        public Vector<double> IndependentChemicalVariablesVector()
        {
            var variablesArray = new[]
            {
                Glucose,
            };
            return Vector.Build.DenseOfArray(variablesArray);
        }

        public Vector<double> DependentChemicalVariablesVector()
        {
            var variablesArray = new[]
            {
                Ethanol,
                Biomass,
            };
            return Vector.Build.DenseOfArray(variablesArray);
        }

        public Vector<double> ChemicalVariablesVector()
        {
            var variablesArray = new[]
            {
                Glucose,
                Ethanol,
                Biomass,
            };
            return Vector.Build.DenseOfArray(variablesArray);
        }

        public Vector<double> ProcessVariablesVector()
        {
            {
                var variablesArray = new[]
                {
                    Flowrate,
                    Volume,
                };
                return Vector.Build.DenseOfArray(variablesArray);
            }
        }

        public Vector<double> StateVariablesVector()
        {
            {
                var variablesArray = new[]
                {
                    Glucose,
                    Ethanol,
                    Biomass,
                    Flowrate,
                    Volume,
                };
                return Vector.Build.DenseOfArray(variablesArray);
            }
        }
    }
}