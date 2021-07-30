using JetBrains.Annotations;

namespace StateVariables
{
    [PublicAPI]
    public interface IStateVariables
    {
        double Glucose { get; set; }
        double Ethanol { get; set; }
        double Biomass { get; set; }
        double Furfural { get; set; }
    }
}