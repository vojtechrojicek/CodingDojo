using FluentAssertions;
using Xunit;

namespace BattlePlan_v1._0._0
{
    /*
    Usually when you buy something, you're asked whether your credit card number,
    phone number or answer to your most secret question is still correct. However, since someone
    could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

    Your task is to write a function maskify, which changes all but the last four characters into '#'.

    Examples
    "4556364607935616" --> "############5616"
            "64607935616" -->      "#######5616"
                    "1" -->                "1"
                    "" -->                 ""

    // "What was the name of your first pet?"

    "Skippy" --> "##ippy"

    "Nananananananananananananananana Batman!"
    -->
    "####################################man!"
    */
    public class _2_3_CreditCardMaskTests
    {
        [Fact]
        public void Maskify()
        {
            _2_3_CreditCardMask.Maskify("4556364607935616").Should().Be("############5616");
            _2_3_CreditCardMask.Maskify("1").Should().Be("1");
            _2_3_CreditCardMask.Maskify("11111").Should().Be("11111");
        }
    }
}