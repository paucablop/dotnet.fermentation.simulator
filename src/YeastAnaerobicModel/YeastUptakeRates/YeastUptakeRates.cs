using Fermentation.Kinetic.Interfaces;
using Fermentation.Simulator.Interfaces;
using Fermentation.Simulator.Yeast.Anaerobic.Model.KineticRates;
using JetBrains.Annotations;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model.YeastUptakeRates
{
    [PublicAPI]
    public class YeastUptakeRates : IYeastModel
    {
        public IMonodInhibition GlucoseUptake { get; set; }
        public ISuddenInhibition EthanolInhibitsGlucose { get; set; }

        public YeastUptakeRates()
        {
            GlucoseUptake = new GlucoseUptake();
            EthanolInhibitsGlucose = new EthanolInhibitsGluocse();
        }

        public double GlucoseUptakeRate(IStateVariables stateVariables)
        {
            return GlucoseUptake.Calculate(stateVariables.Glucose) *
                   EthanolInhibitsGlucose.Calculate(stateVariables.Ethanol) *
                   stateVariables.Biomass;
        }
    }
}