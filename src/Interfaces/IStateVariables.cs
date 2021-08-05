using JetBrains.Annotations;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IStateVariables : ICompounds
    {
        double Flowrate { get; set; }
        double Volume { get; set; }
    }
}