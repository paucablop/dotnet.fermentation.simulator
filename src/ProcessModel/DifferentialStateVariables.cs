using Fermentation.Simulator.Interfaces;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Fermentation.Simulator.Process.Model
{
    public class DifferentialStateVariables : IStateVariables
    {
        public double Glucose { get; set; }
        public double Furfural { get; set; }
        public double Ethanol { get; set; }
        public double Biomass { get; set; }
        public double Flowrate { get; set; }
        public double Volume { get; set; }

        public DifferentialStateVariables()
        {
            Glucose = 0;
            Furfural = 0;
            Ethanol = 0;
            Biomass = 0;
            Flowrate = 0;
            Volume = 0;
        }

        public void FlowRateAndVolumeFromVector(Vector<double> flowRateAndVolume)
        {
            Flowrate = flowRateAndVolume[0];
            Volume = flowRateAndVolume[1];
        }

        public void CompoundsFromVector(Vector<double> compounds)
        {
            Glucose = compounds[0];
            Furfural = compounds[1];
            Ethanol = compounds[2];
            Biomass = compounds[3];
        }

        public Vector<double> ToVector()
        {
            var stateVariablesArray = new[]
                {this.Glucose, this.Furfural, this.Ethanol, this.Biomass, this.Flowrate, this.Volume};
            return Vector.Build.DenseOfArray(stateVariablesArray);
        }
    }
}