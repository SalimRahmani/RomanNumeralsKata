﻿using NUnit.Framework;
using RomanNumeralsKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKataTest
{
    public class RomanNumeralsTest
    {
        private RomanNumeralsProcessor _romanNumeralsProcessor = new RomanNumeralsProcessor();

        [TestCase(1, "I")]
        public void should_return_I_when_input_is_1(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2, "II")]
        [TestCase(3, "III")]
        public void should_return_equal_number_of_strokes_when_input_is_lower_than_4(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(4, "IV")]
        public void should_return_IV_when_number_is_4(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(5, "V")]
        public void should_return_V_when_number_is_5(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(6, "VI")]
        public void should_return_VI_when_number_is_6(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(7, "VII")]
        public void should_return_VII_when_number_is_7(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(8, "VIII")]
        public void should_return_VIII_when_number_is_8(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(9, "IX")]
        public void should_return_IX_when_number_is_9(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(19, "XIX")]
        public void should_return_XIX_when_number_is_19(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(50, "L")]
        public void should_return_L_when_number_is_50(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(80, "LXXX")]
        public void should_return_LXXX_when_number_is_80(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
