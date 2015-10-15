namespace RomanNumeralKata
{
    using System.Collections.Generic;

    public class RomanNumerals
    {
        private readonly IDictionary<int, string> conversion = new Dictionary<int, string>();

        public RomanNumerals()
        {
            conversion[1000] = "m";
            conversion[900] = "cm";
            conversion[500] = "d";
            conversion[400] = "cd";
            conversion[100] = "c";
            conversion[90] = "xc";
            conversion[50] = "l";
            conversion[40] = "xl";
            conversion[10] = "x";
            conversion[9] = "ix";
            conversion[5] = "v";
            conversion[4] = "iv";
            conversion[1] = "i";
        }

        public string Convert(int number)
        {
            var output = "";

            foreach (var key in conversion.Keys)
            {
                while (key <= number)
                {
                    output += conversion[key];
                    number -= key;
                }
            }

            return output;
        }
    }
}