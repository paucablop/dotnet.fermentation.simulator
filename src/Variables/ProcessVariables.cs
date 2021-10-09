using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Variables
{
    [PublicAPI]
    public class ProcessVariables : IProcessVariables
    {
        public double Flowrate { get; set; }
        public double Volume { get; set; }

        public ProcessVariables()
        {
        }

        public ProcessVariables(Vector<double> stateVariablesVector)
        {
            Flowrate = stateVariablesVector[3];
            Volume = stateVariablesVector[4];
        }

        public Vector<double> ProcessVariablesVector()
        {
            var variablesArray = new[]
            {
                Flowrate,
                Volume,
            };
            return Vector.Build.DenseOfArray(variablesArray);
        }
    }
}