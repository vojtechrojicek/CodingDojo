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
        }

        [Fact]
        public void _1_3_DefineCardSuitTest()
        {
        }

        [Fact]
        public void _2_1_DontGiveMeFiveTest()
        {
        }

        [Fact]
        public void _2_2_JadenCasingStringsTest()
        {
        }

        [Fact]
        public void _2_3_CreditCardMaskTest()
        {
        }

        [Fact]
        public void _2_4_BinaryAdditionTest()
        {
        }

        [Fact]
        public void _2_5_PrinterErrorsTest()
        {
        }

        [Fact]
        public void _2_6_TwoToOneTest()
        {
        }

        [Fact]
        public void _3_1_PersistentBuggerTest()
        {
        }

        [Fact]
        public void _3_2_LonelyFrogTest()
        {
        }
    }
}