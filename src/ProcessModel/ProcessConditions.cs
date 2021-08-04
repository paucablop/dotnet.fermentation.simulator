using Fermentation.Simulator.Interfaces;
using JetBrains.Annotations;

namespace Fermentation.Simulator.Process.Model
{
    [PublicAPI]
    public class ProcessConditions: IProcessConditions
    {
        public double FlowRate { get; set; }
        public double MaxVolume { get; set; }

        public ProcessConditions(float volume, float initialFlowRate)
        {
            MaxVolume = 10.0;
        }
        
    }
}