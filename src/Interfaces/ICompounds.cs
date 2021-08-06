using JetBrains.Annotations;
using MathNet.Numerics.LinearAlgebra;

namespace Fermentation.Simulator.Interfaces
{
    [PublicAPI]
    public interface ICompounds: IModelVariables
    {
        double Glucose { get; set; }
        double Furfural { get; set; }
        double Ethanol { get; set; }
        double Biomass { get; set; }
    }
}
