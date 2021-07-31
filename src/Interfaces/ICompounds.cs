using JetBrains.Annotations;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface ICompounds
    {
        double Glucose { get; set; }
        double Furfural { get; set; }
        double Ethanol { get; set; }
        double Biomass { get; set; }
    }
}