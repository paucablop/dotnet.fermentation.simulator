using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Variables
{
    [PublicAPI]
    public class StateVariables : IStateVariables
    {
        public double Glucose { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public double Flowrate { get; set; }
        public double Volume { get; set; }

        public StateVariables()
        {
        }

        public StateVariables(Vector<double> stateVariablesVector)
        {
            Glucose = stateVariablesVector[0];
            Ethanol = stateVariablesVector[1];
            Biomass = stateVariablesVector[2];
            Flowrate = stateVariablesVector[3];
            Volume = stateVariablesVector[4];
        }

        public void StateVariablesFromChemicalVariablesVector(Vector<double> chemicalVariablesVector)
        {
            Glucose = chemicalVariablesVector[0];
            Ethanol = chemicalVariablesVector[1];
            Biomass = chemicalVariablesVector[2];
        }

        public void StateVariablesFromProcessVariablesVector(Vector<double> processVariablesVector)
        {
            Flowrate = processVariablesVector[0];
            Volume = processVariablesVector[1];
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