using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public class StateVariables : IStateVariables
    {
        public double Glucose { get; set; }
        public double Xylose { get; set; }
        public double Furfural { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public double Flowrate { get; set; }
        public double Volume { get; set; }
        
        public StateVariables(Vector<double> stateVariablesVector)
        {
            Glucose = stateVariablesVector[0];
            Ethanol = stateVariablesVector[1];
            Biomass = stateVariablesVector[2];
            Volume = stateVariablesVector[4];
            Flowrate = Volume <= 10 ? stateVariablesVector[3] : 0.0;
        }

        public Vector<double> ToVector()
        {
            var stateVariables =
                new[]
                {
                    Glucose,
                    Ethanol,
                    Biomass,
                    Flowrate,
                    Volume
                };
            return Vector.Build.DenseOfArray(stateVariables);
        }

        public Vector<double> AppendVectors(Vector<double> compounds, Vector<double> flowrateAndVolume)
        {
            var variables =
                new[]
                {
                    compounds[0],
                    compounds[1],
                    compounds[2],
                    flowrateAndVolume[0],
                    flowrateAndVolume[1]
                };
            return Vector.Build.DenseOfArray(variables);
        }
    }
}
