using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public class InitialConditions : IStateVariables
    {
        public double Glucose { get; set; }
        public double Xylose { get; set;  }
        public double Furfural { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public double Flowrate { get; set; }
        public double Volume { get; set; }
        
        public InitialConditions()
        {
            Glucose = 40.0;
            Ethanol = 1.0;
            Biomass = 1.0;
            Flowrate = 0.5;
            Volume = 1.0;
        }

        public Vector<double> ToVector()
        {
            var variables =
                new[]
                {
                    Glucose,
                    Ethanol,
                    Biomass,
                    Flowrate,
                    Volume
                };
            return Vector.Build.DenseOfArray(variables);
        }
    }
}
