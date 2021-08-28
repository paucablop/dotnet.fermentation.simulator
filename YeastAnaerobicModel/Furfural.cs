﻿using Fermentation.Kinetic.Interfaces;
using Fermentation.Kinetic.Models;
using JetBrains.Annotations;
using MathNet.Numerics.Distributions;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model
{
    [PublicAPI]
    public record FurfuralUptake : IMonod
    {
        public double MaxUptakeRate { get; set; }
        public double AffinityConstant { get; set; }
        
        public FurfuralUptake()
        {
            MaxUptakeRate = Normal.Sample(0.01, 0.0001);
            AffinityConstant = Normal.Sample(2.0, 0.02);
        }
        public double Calculate(double furfuralConcentration)
        {
            return UptakeModels.Monod(furfuralConcentration, MaxUptakeRate, AffinityConstant);
        }
    }

    [PublicAPI]
    public record FurfuralInhibitsGlucose : IInverseInhibition
    {
        public double InhibitionConstant { get; set; }

        public FurfuralInhibitsGlucose()
        {
            InhibitionConstant = Normal.Sample(5.0, 0.05);
        }

        public double Calculate(double furfuralConcentration)
        {
            return Inhibition.InverseInhibition(furfuralConcentration, InhibitionConstant);
        }     
    }
}
