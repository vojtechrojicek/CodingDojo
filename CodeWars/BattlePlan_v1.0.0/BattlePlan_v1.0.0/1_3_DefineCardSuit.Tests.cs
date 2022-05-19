using FluentAssertions;
using Xunit;

namespace BattlePlan_v1._0._0
{
    /*
    You get any card as an argument. Your task is to return the suit of this card (in lowercase).

    Our deck (is preloaded):

    string[] Deck =
    {
        "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
        "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
        "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
        "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
    };
    DefineSuit("3♣") -> return "clubs"
    DefineSuit("3♦") -> return "diamonds"
    DefineSuit("3♥") -> return "hearts"
    DefineSuit("3♠") -> return "spades"
    */
    public class _1_3_DefineCardSuitTests
    {
        public static string[] Deck = new []
        {
            "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
            "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
            "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
            "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
        };

        [Fact]
        public void DefineSuit()
        {
            DefineCardSuit.DefineSuit("3♣").Should().Be("clubs");
            DefineCardSuit.DefineSuit("Q♠").Should().Be("spades");
            DefineCardSuit.DefineSuit("9♦").Should().Be("diamonds");
            DefineCardSuit.DefineSuit("J♥").Should().Be("hearts");
        }
    }
}