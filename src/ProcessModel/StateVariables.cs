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
        public double Furfural { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public double Flowrate { get; set; }
        public double Volume { get; set; }

        public StateVariables(Vector<double> stateVariablesVector)
        {
            Glucose = stateVariablesVector[0];
            Furfural = stateVariablesVector[1];
            Ethanol = stateVariablesVector[2];
            Biomass = stateVariablesVector[3];
            Volume = stateVariablesVector[5];
            Flowrate = Volume <= 4 ? stateVariablesVector[4] : 0.0;
        }

        public Vector<double> ToVector()
        {
            var variables =
                new[]
                {
                    Glucose,
                    Furfural,
                    Ethanol,
                    Biomass,
                    Flowrate,
                    Volume
                };
            return Vector.Build.DenseOfArray(variables);
        }

        public Vector<double> FromVectorsToVector(Vector<double> compounds, Vector<double> flowrateAndVolume)
        {
            var variables =
                new[]
                {
                    compounds[0],
                    compounds[1],
                    compounds[2],
                    compounds[3],
                    flowrateAndVolume[0],
                    flowrateAndVolume[1]
                };
            return Vector.Build.DenseOfArray(variables);
        }
    }
}
