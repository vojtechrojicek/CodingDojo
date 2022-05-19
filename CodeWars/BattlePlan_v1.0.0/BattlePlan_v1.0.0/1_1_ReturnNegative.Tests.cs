using FluentAssertions;
using Xunit;

namespace BattlePlan_v1._0._0
{
    /*
    In this simple assignment you are given a number and have to make it negative. But maybe the number is already negative?

    Examples:

    ReturnNegative.MakeNegative(1);  // return -1
    ReturnNegative.MakeNegative(-5); // return -5
    ReturnNegative.MakeNegative(0);  // return 0

    Notes:

    The number can be negative already, in which case no change is required.
    Zero (0) is not checked for any specific sign. Negative zeros make no mathematical sense.
    */
    public class _1_1_ReturnNegativeTests
    {
        [Fact]
        public void MakeNegative()
        {
            ReturnNegative.MakeNegative(42).Should().Be(-42);
        }
    }
}