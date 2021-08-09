using System;
using Fermentation.Kinetic.Interfaces;
using JetBrains.Annotations;
using MathNet.Numerics.Distributions;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model
{
    [PublicAPI]
    public class EthanolInhibition : ISuddenInhibition
    {
        public double InhibitionConstant { get; set; }
        public double ExponentialConstant { get; set; }

        public EthanolInhibition(bool randomize)
        {
            if (!randomize)
            {
                InhibitionConstant = 20.0;
                ExponentialConstant = 0.5;
            }
            else
            {
                InhibitionConstant = Normal.Sample(20.0, 1.0);
                ExponentialConstant = Normal.Sample(0.5, 0.05);
            }
        }
    }
}
