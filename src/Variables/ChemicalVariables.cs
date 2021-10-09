using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Variables
{
    [PublicAPI]
    public class ChemicalVariables : IChemicalVariables
    {
        public double Glucose { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }

        public ChemicalVariables()
        {
        }

        public ChemicalVariables(Vector<double> stateVariablesVector)
        {
            Glucose = stateVariablesVector[0];
            Ethanol = stateVariablesVector[1];
            Biomass = stateVariablesVector[2];
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
    }
}