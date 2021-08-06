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
            Glucose = 0.0;
            Furfural = 0.0;
            Ethanol = 0.0;
            Biomass = 0.0;
            Flowrate = 0.0;
            Volume = 0.0;
        }

        public Vector<double> CompoundsToVector()
        {
            var compoundsVector = new double[]
            {
                this.Glucose,
                this.Furfural,
                this.Ethanol,
                this.Biomass
            };
            return Vector.Build.DenseOfArray(compoundsVector);
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
    }
}
