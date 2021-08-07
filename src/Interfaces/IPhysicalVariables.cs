using JetBrains.Annotations;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IPhysicalVariables: IModelVariables
    {
        double Flowrate { get; set; }
        double Volume { get; set; }
    }
}
