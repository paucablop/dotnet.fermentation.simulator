using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IYeastModel
    {
        IMonodInhibition GlucoseUptake { get; set; }
        ISuddenInhibition EthanolInhibitsGlucose { get; set; }
        public double GlucoseUptakeRate(IStateVariables stateVariables);
    }
}