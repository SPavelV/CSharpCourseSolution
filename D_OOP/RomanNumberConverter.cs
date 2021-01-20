using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    class RomanNumberConverter
    {
        // III
        // IV = 5 - 1 = 4
        // XIV = 10 - 5 - 1 = 14
        private static Dictionary<char, int> map = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }

        };

        public static int Parse(string roman)
        {
            int result = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if(i + 1 < roman.Length && isSubtractive(roman[i], roman[i + 1]))
                {
                    result -= map[roman[i]];
                } else {
                    result += map[roman[i]];
                }
            }
            return result;
        }

        private static bool isSubtractive(char c1, char c2)
        {
            return map[c1] < map[c2];
        }
    }
}
