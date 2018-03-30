using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralsProcessor
    {
        private readonly SortedDictionary<int, char> _romanNumsBasics = new SortedDictionary<int, char>()
            {
                { 1, 'I' },
                { 5, 'V' },
                { 10, 'X' },
                { 50, 'L' },
                { 100, 'C' },
                { 500, 'D' },
                { 1000, 'M' },
            };

        public string ToRomanNumerals(int number)
        {
            if (_romanNumsBasics.TryGetValue(number, out char value))
            {
                return value.ToString();
            }

            StringBuilder stringBuilder = new StringBuilder();

            foreach (KeyValuePair<int, char> pair in _romanNumsBasics.Reverse())
            {
                int remainder = number % pair.Key;
                int quotient = number / pair.Key;
                if(remainder != number)
                {
                    stringBuilder.Append(new String(_romanNumsBasics[pair.Key], quotient));

                    if(quotient >= 1 && remainder != 0)
                    {
                        string remainderRomanNumeral = ToRomanNumerals(remainder);
                        stringBuilder.Append(remainderRomanNumeral);
                    }
                    else if(quotient < 0)
                    {
                        string remainderStr = ToRomanNumerals(remainder);
                        stringBuilder.Insert(0, remainderStr);
                    }
                    break;
                }
                else
                {
                    if (Math.Abs(number - pair.Key) == 1)
                    {
                        stringBuilder.Append("I");
                        stringBuilder.Append(pair.Value.ToString());
                        break;
                    }
                }
            }

            return stringBuilder.ToString();
        }
    }
}   
