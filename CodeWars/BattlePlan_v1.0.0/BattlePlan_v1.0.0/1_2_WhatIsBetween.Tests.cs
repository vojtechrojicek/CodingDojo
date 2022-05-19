using FluentAssertions;
using Xunit;

namespace BattlePlan_v1._0._0
{
    /*
    Complete the function that takes two integers (a, b, where a < b) and return an array
    of all integers between the input parameters, including them.

    For example
    a = 1
    b = 4
    --> [1, 2, 3, 4]
    */
    public class _1_2_WhatIsBetweenTests
    {
        [Fact]
        public void Between()
        {
            WhatIsBetween.Between(0, 3).Should().BeEquivalentTo(new int[] { 0, 1, 2, 3 });
            WhatIsBetween.Between(-2, 2).Should().BeEquivalentTo(new int[] { -2, -1, 0, 1, 2 });
            WhatIsBetween.Between(-10, 10).Should().BeEquivalentTo(new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }
    }
}