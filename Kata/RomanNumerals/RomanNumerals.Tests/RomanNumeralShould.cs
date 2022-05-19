using FluentAssertions;
using RomanNumerals;
using Xunit;

/// <summary>
/// Create method that is capable of transforming any of the first 10 arabic numbers
/// into their roman equivalent:
/// I = 1, II = 2, III = 3, IV = 4, V = 5, .... X = 10
/// </summary>
public class RomanNumeralShould
{
    [Fact]
    public void ConvertToRoman()
    {
        //RomanNumeral.ConvertToRoman(0).Should().BeEquivalentTo("");
        //RomanNumeral.ConvertToRoman(1).Should().BeEquivalentTo("I");
        //RomanNumeral.ConvertToRoman(2).Should().BeEquivalentTo("II");
        //RomanNumeral.ConvertToRoman(3).Should().BeEquivalentTo("III");
        //RomanNumeral.ConvertToRoman(4).Should().BeEquivalentTo("IV");
        //RomanNumeral.ConvertToRoman(5).Should().BeEquivalentTo("V");
        //RomanNumeral.ConvertToRoman(6).Should().BeEquivalentTo("VI");
        //RomanNumeral.ConvertToRoman(7).Should().BeEquivalentTo("VII");
        //RomanNumeral.ConvertToRoman(8).Should().BeEquivalentTo("VIII");
        RomanNumeral.ConvertToRoman(9).Should().BeEquivalentTo("IX");
        RomanNumeral.ConvertToRoman(10).Should().BeEquivalentTo("X");
    }
}