using System;
using FluentAssertions;
using MathNet.Numerics.LinearAlgebra;
using Xunit;

namespace UnitTests
{
    public class SolveModelUnitTest
    {
        [Fact]
        public void TestOdeSolution()
        {
            // Arrange
            var startingTime = 0.0;
            var endingTime = 10.0;
            var timeSteps = 100;

            var initialConditions = Vector<double>.Build.Dense(2, 1.0);

            Func<double, Vector<double>, Vector<double>> differentialEquations = (t, concentrations) =>
                BatchOperation.MassBalanance.DifferentialEquationsSystem(concentrations);

            // Act
            var fermentationProfile =
                MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(initialConditions, startingTime, endingTime,
                    timeSteps,differentialEquations);


            // Assert
            fermentationProfile.Should().BeOfType(typeof(Vector<double>));
        }
    }
}