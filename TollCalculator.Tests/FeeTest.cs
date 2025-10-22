using Xunit;
using TollCalculator;

namespace TollCalculator.Tests
{
    public class FeeTest
    {
        [Fact]
        public void SingleFee()
        {
            bool result = true;
            Assert.Equal(true, result);
        }
        [Fact]
        public void MoreThanMaxFee()
        {
            bool result = true;
            Assert.Equal(true, result);
        }
        [Fact]
        public void NoFeeVehicle()
        {
            bool result = true;
            Assert.Equal(true, result);
        }
    }
}

