﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBowlNamer
{
    public class NumberCoverter
    {
        public int ConvertRomanNumeralToNumber(string RomanNumeral)
        {
            var counter = RomanNumeral;
            var result = 0;
            foreach (var character in RomanNumeral)
            {
                result += ConvertCharacterToNumber(character);
            }
            return result;
        }

        private int ConvertCharacterToNumber(char character)
        {
            switch (character)
            {
                case 'M': return 1000;
                case 'D': return 500;
                case 'C': return 100;
                case 'L': return 50;
                case 'X': return 10;
                case 'V': return 5;
                case 'I': return 1;
                default: throw new ArgumentException("Invalid character");
            }
        }
    }
}
