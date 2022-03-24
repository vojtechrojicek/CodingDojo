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
        var roman = RomanNumeral.ConvertToRoman(0);

        roman.Should().BeEquivalentTo("");
    }
}