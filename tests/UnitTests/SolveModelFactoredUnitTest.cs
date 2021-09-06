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
            var startTime = 0.0;
            var endTime = 40.0;
            var timeSteps = 10000;
            var initialConditions = new InitialConditions().ToVector();
            
            // Act
            var fermentationProfile =
                Simulator.Run(initialConditions, startTime, endTime, timeSteps);
            PlotFermentation.Plot(fermentationProfile, startTime, endTime);
            
            // Assert
            fermentationProfile[0][0].Should().Be(40.0);
            fermentationProfile[80][2].Should().BeApproximately( 19.998609617882803, 5e-1);

        }
    }
}
