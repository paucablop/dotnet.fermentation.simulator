using JetBrains.Annotations;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IStateVariables : IChemicalVariables, IPhysicalVariables
    {
    }
}
