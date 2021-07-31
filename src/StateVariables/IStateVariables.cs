using JetBrains.Annotations;

namespace Fermentation.Simulator.State.Variables
{
    [PublicAPI]
    public interface IStateVariables
    {
        double Glucose { get; set; }
        double Furfural { get; set; }
        double Ethanol { get; set; }
        double Biomass { get; set; }
    }
}