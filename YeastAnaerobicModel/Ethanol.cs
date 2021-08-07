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

        public EthanolInhibition()
        {
            InhibitionConstant = Normal.Sample(10.0, 0.5);
            ExponentialConstant = Normal.Sample(0.5, 0.05);
        }
    }
}
