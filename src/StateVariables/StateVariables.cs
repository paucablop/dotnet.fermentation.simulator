using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace StateVariables
{
    [PublicAPI]
    public class StateVariables : IStateVariables
    {
        public StateVariables(Vector<double> stateVariablesVector)
        {
            Glucose = stateVariablesVector[0];
            Ethanol = stateVariablesVector[1];
            Biomass = stateVariablesVector[2];
            Furfural = stateVariablesVector[3];
        }

        public double Glucose { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public double Furfural { get; set; }
        
    }
}