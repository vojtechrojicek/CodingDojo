using FluentAssertions;
using Xunit;

namespace BattlePlan_v1._0._0
{
    /*
    Take 2 strings s1 and s2 including only letters from ato z.
    Return a new sorted string, the longest possible,
    containing distinct letters - each taken only once - coming from s1 or s2.

    Examples:
    a = "xyaabbbccccdefww"
    b = "xxxxyyyyabklmopq"
    longest(a, b) -> "abcdefklmopqwxy"

    a = "abcdefghijklmnopqrstuvwxyz"
    longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"
    */
    public class _2_6_TwoToOneTests
    {
        [Fact]
        public void Longest()
        {
            _2_6_TwoToOne.Longest("aretheyhere", "yestheyarehere")
                .Should()
                .Be("aehrsty");
            _2_6_TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding")
                .Should()
                .Be("abcdefghilnoprstu");
            _2_6_TwoToOne.Longest("inmanylanguages", "theresapairoffunctions")
                .Should()
                .Be("acefghilmnoprstuy");
        }
    }
}