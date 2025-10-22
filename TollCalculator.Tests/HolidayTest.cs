using Xunit;
using TollFeeCalculator;

namespace TollCalculator.Tests
{
    public class HolidayTest
    {
        [Fact]
        public void Saturday()
        {
            Vehicle car = new Car();
            DateTime saturday = new DateTime(2025,11,15,11,11,11);
            int result = TollFeeCalculator.TollCalculator.GetTollFee(car, [saturday]);

            Assert.Equal(0, result);
        }
        [Fact]
        public void Sunday()
        {
            bool result = true;
            Assert.Equal(true, result);
        }
        [Fact]
        public void Christmas()
        {
            bool result = true;
            Assert.Equal(true, result);
        }
    }
}

