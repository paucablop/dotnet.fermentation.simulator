using Fermentation.Simulation.Plotting;
using Fermentation.Simulator.Mass.Balance;
using Fermentation.Simulator.Process.Model;
using FluentAssertions;
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
            var endingTime = 100.0;
            var timeSteps = 100;
            var initialConditions = new InitialConditions().ToVector();
            // Act
            var fermentationProfile =
                Simulator.Run(initialConditions, startingTime, endingTime, timeSteps);
            PlotFermentation.Plot(fermentationProfile);
            // Assert
            fermentationProfile[0][0].Should().Be(40.0);
            fermentationProfile[80][2].Should().BeApproximately( 19.998609617882803, 1e-1);

        }
    }
}
