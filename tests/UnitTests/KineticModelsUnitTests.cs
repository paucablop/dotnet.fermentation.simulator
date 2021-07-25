using Fermentation.Simulator.KineticModels;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class KineticModelsUnitTests
    {
        [Fact]
        public void TestMonod()
        {
            // Arrange
            var substrateConcentration = 0.5;
            var maxGrowthRate = 1;
            var affinityConstant = 0.5;

            // Act
            var rate = MonodModels.SimpleMonod(substrateConcentration, maxGrowthRate, affinityConstant);

            // Assert
            rate.Should().Be(0.5);
        }

        [Fact]
        public void TestMonodSubstrateInhibition()
        {
            // Arrange
            var substrateConcentration = 0.5;
            var maxGrowthRate = 1;
            var affinityConstant = 0.5;
            var substrateInhibitionConstant = 1;

            // Act
            var rate = MonodModels.MonodSubstrateInhibition(substrateConcentration, maxGrowthRate, affinityConstant,
                substrateInhibitionConstant);

            // Assert
            rate.Should().Be(0.4);
        }
    }
}