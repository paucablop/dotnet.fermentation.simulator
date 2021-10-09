using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public record ProcessConditions : IProcessVariables
    {
        public double Flowrate { get; set; }
        public double Volume { get; set; }

        public ProcessConditions()
        {
            Volume = 10;
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