using JetBrains.Annotations;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IChemicalVariables: IModelVariables
    {
        double Glucose { get; set; }
        double Furfural { get; set; }
        double Ethanol { get; set; }
        double Biomass { get; set; }
    }
}
