﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralsProcessor
    {
        private readonly SortedDictionary<int, string> _romanNumsBasics = new SortedDictionary<int, string>()
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" },
        };

        private readonly SortedDictionary<char, int> _arabicNumsBasics = new SortedDictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        public string ToRomanNumerals(int number)
        {
            if (number > 3000)
            {
                throw new ArgumentException("RomanNumber only supports numbers up to 3000");
            }
            StringBuilder result = new StringBuilder();

            foreach(KeyValuePair<int, string> pair in _romanNumsBasics.Reverse())
            {
                while(number >= pair.Key)
                {
                    number -= pair.Key;
                    result.Append(pair.Value);
                }
            }

            return result.ToString();
        }

        public int ToArabicNumbers(string input)
        {
            int result = 0;
            int lastValue = 0;
            for(int i = input.Length - 1; i >= 0; i--)
            {
                int newValue = _arabicNumsBasics[input[i]];

                if(newValue >= lastValue)
                {
                    result += newValue;
                    lastValue = newValue;
                }
                else
                {
                    result -= newValue;
                }
            }

            return result;
        }
    }
}   
