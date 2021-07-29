using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;

namespace Yeast.Kinetic.Model
{
    [PublicAPI]
    public record ProductInhibition : ISuddenProductInhibition
    {
        public double InhibitionConstant { get; init; }
        public double InhibitionExponent { get; init; }

        public ProductInhibition()
        {
            InhibitionConstant = 1.0;
            InhibitionExponent = 0.5;
        }
    }
}