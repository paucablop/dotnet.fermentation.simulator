﻿using Fermentation.Kinetic.Interfaces;
using Fermentation.Kinetic.Models;
using JetBrains.Annotations;
using MathNet.Numerics.Distributions;

namespace Fermentation.Simulator.Yeast.Anaerobic.Model

{
    [PublicAPI]
    public record GlucoseUptake : IMonodInhibition
    {
        public double MaxUptakeRate { get; set; }
        public double AffinityConstant { get; set; }
        public double InhibitionConstant { get; set; }

        public GlucoseUptake()
        {
            MaxUptakeRate = 1.0;
            AffinityConstant = 0.5;
            InhibitionConstant = 100;
        }

        public double Calculate(double glucoseConcentration)
        {
            return UptakeModels.MonodSubstrateInhibition(glucoseConcentration, MaxUptakeRate, AffinityConstant,
                InhibitionConstant);
        }
    }
}
