using Fermentation.Simulation.Plotting;
using Fermentation.Simulator.Mass.Balance;
using Fermentation.Simulator.Process.Model;
using FluentAssertions;
using MathNet.Numerics.LinearAlgebra;
using Xunit;

namespace UnitTests
{
    public class SolveModelFactoredUnitTest
    {
        [Fact]
        public void TestFSharpOdeSolution()
        {
            // Arrange
            var startingTime = 0.0;
            var endingTime = 10.0;
            var timeSteps = 10;
            var initialConditions = new InitialConditions().ToVector();
            // Act
            var fermentationProfile =
                Program.Run(initialConditions, startingTime, endingTime, timeSteps);
            // Assert
            fermentationProfile[0][0].Should().Be(1.0);
            fermentationProfile[80][2].Should().BeApproximately( 1.509982539693151, 1e-3);

        }
    }
}
