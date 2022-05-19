using BattlePlan_v1._0._0;
using FluentAssertions;
using Xunit;

namespace FinalTests
{
    public class FinalTests
    {
        [Fact]
        public void _1_1_ReturnNumberTest()
        {
            ReturnNegative.MakeNegative(42).Should().Be(-42);
            ReturnNegative.MakeNegative(0).Should().Be(0);
            ReturnNegative.MakeNegative(-10).Should().Be(-10);
            ReturnNegative.MakeNegative(100).Should().Be(-100);
        }

        [Fact]
        public void _1_2_WhatIsBetweenTest()
        {
            WhatIsBetween.Between(0, 3).Should().BeEquivalentTo(new int[] { 0, 1, 2, 3 });
            WhatIsBetween.Between(-2, 2).Should().BeEquivalentTo(new int[] { -2, -1, 0, 1, 2 });
            WhatIsBetween.Between(-10, 10).Should().BeEquivalentTo(new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            WhatIsBetween.Between(-2, 0).Should().BeEquivalentTo(new int[] { -2, -1, 0 });
        }

        [Fact]
        public void _1_3_DefineCardSuitTest()
        {
            DefineCardSuit.DefineSuit("3♣").Should().Be("clubs");
            DefineCardSuit.DefineSuit("Q♠").Should().Be("spades");
            DefineCardSuit.DefineSuit("9♦").Should().Be("diamonds");
            DefineCardSuit.DefineSuit("J♥").Should().Be("hearts");
            DefineCardSuit.DefineSuit("10♣").Should().Be("clubs");
            DefineCardSuit.DefineSuit("10♠").Should().Be("spades");
            DefineCardSuit.DefineSuit("10♦").Should().Be("diamonds");
            DefineCardSuit.DefineSuit("10♥").Should().Be("hearts");
            DefineCardSuit.DefineSuit("2♣").Should().Be("clubs");
            DefineCardSuit.DefineSuit("2♠").Should().Be("spades");
            DefineCardSuit.DefineSuit("2♦").Should().Be("diamonds");
            DefineCardSuit.DefineSuit("2♥").Should().Be("hearts");
        }

        [Fact]
        public void _2_1_DontGiveMeFiveTest()
        {
            _2_1_DontGiveMeFive.DontGiveMeFive(1, 9).Should().Be(8);
            _2_1_DontGiveMeFive.DontGiveMeFive(4, 17).Should().Be(12);
        }

        [Fact]
        public void _2_2_JadenCasingStringsTest()
        {
            _2_2_JadenCasingStrings
                .ToJadenCase("How can mirrors be real if our eyes aren't real")
                .Should()
                .Be("How Can Mirrors Be Real If Our Eyes Aren't Real");
        }

        [Fact]
        public void _2_3_CreditCardMaskTest()
        {
            _2_3_CreditCardMask.Maskify("4556364607935616").Should().Be("############5616");
            _2_3_CreditCardMask.Maskify("1").Should().Be("1");
            _2_3_CreditCardMask.Maskify("11111").Should().Be("11111");
            _2_3_CreditCardMask.Maskify("").Should().Be("");
            _2_3_CreditCardMask.Maskify("Nananananananananananananananana Batman!")
                .Should()
                .Be("####################################man!");
        }

        [Fact]
        public void _2_4_BinaryAdditionTest()
        {
            _2_4_BinaryAddition.AddBinary(1, 2).Should().Be("11");
            _2_4_BinaryAddition.AddBinary(5, 9).Should().Be("1110");
        }

        [Fact]
        public void _2_5_PrinterErrorsTest()
        {
            _2_5_PrinterErrors.PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz")
                .Should()
                .Be("3/56");
            _2_5_PrinterErrors.PrinterError("aaabbbbhaijjjm")
                .Should()
                .Be("0/14");
            _2_5_PrinterErrors.PrinterError("aaaxbbbbyyhwawiwjjjwwm")
                .Should()
                .Be("8/22");
            _2_5_PrinterErrors.PrinterError("")
                .Should()
                .Be("");
            _2_5_PrinterErrors.PrinterError("xxx")
                .Should()
                .Be("3/3");
        }

        [Fact]
        public void _2_6_TwoToOneTest()
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
            _2_6_TwoToOne.Longest("xyaabbbccccdefww", "xxxxyyyyabklmopq")
                .Should()
                .Be("abcdefklmopqwxy");
            _2_6_TwoToOne.Longest("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz")
                .Should()
                .Be("abcdefghijklmnopqrstuvwxyz");
            _2_6_TwoToOne.Longest("", "")
                .Should()
                .Be("");
            _2_6_TwoToOne.Longest("a", "")
                .Should()
                .Be("a");
            _2_6_TwoToOne.Longest("", "a")
                .Should()
                .Be("a");
        }

        [Fact]
        public void _3_1_PersistentBuggerTest()
        {
            _3_1_PersistentBugger.Persistence(39).Should().Be(3);
            _3_1_PersistentBugger.Persistence(4).Should().Be(0);
            _3_1_PersistentBugger.Persistence(25).Should().Be(2);
            _3_1_PersistentBugger.Persistence(999).Should().Be(4);
        }

        [Fact]
        public void _3_2_LonelyFrogTest()
        {
            _3_2_LonelyFrog.JumpTo(1, 8).Should().Be(3);
            _3_2_LonelyFrog.JumpTo(1, 17).Should().Be(5);
            _3_2_LonelyFrog.JumpTo(1, 15).Should().Be(6);
            _3_2_LonelyFrog.JumpTo(3, 12).Should().Be(2);
            _3_2_LonelyFrog.JumpTo(3, 16).Should().Be(3);
            _3_2_LonelyFrog.JumpTo(3, 17).Should().Be(4);
            _3_2_LonelyFrog.JumpTo(10, 19).Should().Be(9);
        }
    }
}