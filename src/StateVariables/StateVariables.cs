using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace StateVariables
{
    [PublicAPI]
    public class StateVariables : IStateVariables
    {
        public StateVariables(Vector<double> concentrationsVector)
        {
            Glucose = concentrationsVector[0];
            Ethanol = concentrationsVector[1];
            Biomass = concentrationsVector[2];
            Furfural = concentrationsVector[3];
        }

        public double Glucose { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public double Furfural { get; set; }
        
    }
}