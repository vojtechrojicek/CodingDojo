namespace RomanNumerals
{
    public static class RomanNumeral
    {
        public static string ConvertToRoman(int number)
        {
            string result = "";
            if(number < 1)
            {
                result = "";
            }
            else if(number < 4)
            {
                result = "I" + ConvertToRoman(number - 1);
            }
            else if(number == 4)
            {
                result = "IV" + ConvertToRoman(number - 4);
            }
            else if (number < 9)
            {
                result = "V" + ConvertToRoman(number - 5);
            }
            else if (number == 9)
            {
                result = "IX" + ConvertToRoman(number - 9);
            }
            else
            {
                result = "X" + ConvertToRoman(number - 10);
            }

            return result;
        }
    }
}
