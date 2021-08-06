using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface IProcessConditions: IModelVariables
    {
        double Flowrate { get; set; }
        double Volume { get; set; }
    }
}
