using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralsProcessor
    {
        public string ToRomanNumerals(int digit)
        {
            if (digit < 4)
            {
                return new String('I', digit);
            }
            else if (digit == 4)
            {
                return "IV";
            }
            else if (digit == 5)
            {
                return "V";
            }

            return string.Empty;
        }
    }
}
