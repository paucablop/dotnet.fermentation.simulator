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
            var endTime = 100.0;
            var timeSteps = 10000;
            var initialConditionsVector = new InitialConditions().StateVariablesVector();
            
            // Act
            var fermentationProfile =
                SingleBatch.Run(initialConditionsVector, startTime, endTime, timeSteps);
            PlotFermentation.Plot(fermentationProfile, startTime, endTime);
            
            // Assert
            fermentationProfile[0][0].Should().Be(40.0);
            fermentationProfile[5][2].Should().BeApproximately( 0.64348082745224666, 5e-1);

        }
    }
}
