using FluentAssertions;
using Xunit;

namespace BattlePlan_v1._0._0
{
    /*
    Implement a function that adds two numbers together and returns their sum in binary.
    The conversion can be done before, or after the addition.

    The binary number returned should be a string.

    Examples:(Input1, Input2 --> Output (explanation)))

    1, 1 --> "10" (1 + 1 = 2 in decimal or 10 in binary)
    5, 9 --> "1110" (5 + 9 = 14 in decimal or 1110 in binary)
    */
    public class _2_4_BinaryAdditionTests
    {
        [Fact]
        public void AddBinary()
        {
            _2_4_BinaryAddition.AddBinary(1, 2).Should().Be("11");
        }
    }
}