using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Variables
{
    [PublicAPI]
    public class IndependentChemicalVariables : IIndependentChemicalVariables
    {
        public double Glucose { get; set; }

        public IndependentChemicalVariables()
        {
        }
        public IndependentChemicalVariables(Vector<double> stateVariablesVector)
        {
            Glucose = stateVariablesVector[0];
        }

        public Vector<double> IndependentChemicalVariablesVector()
        {
            var variablesArray = new[]
            {
                Glucose,
            };
            return Vector.Build.DenseOfArray(variablesArray);
        }
    }
}