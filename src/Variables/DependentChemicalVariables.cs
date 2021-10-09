using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Variables
{
    [PublicAPI]
    public class DependentChemicalVariables : IDependentChemicalVariables
    {
        public double Ethanol { get; set; }
        public double Biomass { get; set; }

        public DependentChemicalVariables()
        {
        }
        public DependentChemicalVariables(Vector<double> stateVariablesVector)
        {
            Ethanol = stateVariablesVector[1];
            Biomass = stateVariablesVector[2];
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
    }
}