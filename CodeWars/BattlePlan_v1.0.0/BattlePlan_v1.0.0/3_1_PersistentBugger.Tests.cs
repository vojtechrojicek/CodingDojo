using FluentAssertions;
using Xunit;

namespace BattlePlan_v1._0._0
{
    /*
    Write a function, persistence, that takes in a positive
    parameter num and returns its multiplicative persistence,
    which is the number of times you must multiply the digits in num until you reach a single digit.

    For example (Input --> Output):

    39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
    999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2)
    4 --> 0 (because 4 is already a one-digit number)
    */
    public class _3_1_PersistentBuggerTests
    {
        [Fact]
        public void Persistence()
        {
            _3_1_PersistentBugger.Persistence(39).Should().Be(3);
            _3_1_PersistentBugger.Persistence(4).Should().Be(0);
            _3_1_PersistentBugger.Persistence(25).Should().Be(2);
            _3_1_PersistentBugger.Persistence(999).Should().Be(4);
        }
    }
}