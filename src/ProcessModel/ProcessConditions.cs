using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public class ProcessConditions: IProcessConditions
    {
        public double Flowrate { get; set; }
        public double Volume { get; set; }

        public ProcessConditions()
        {
            Flowrate = 0.0;
            Volume = 10.0;
        }

        public Vector<double> ToVector()
        {
            var variables =
                new[]
                {
                    Flowrate,
                    Volume
                };
            return Vector.Build.DenseOfArray(variables);
        }
    }
}
