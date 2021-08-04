using JetBrains.Annotations;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IProcessConditions
    {
        double FlowRate { get; set; }
        double MaxVolume { get; set; }
    }
}