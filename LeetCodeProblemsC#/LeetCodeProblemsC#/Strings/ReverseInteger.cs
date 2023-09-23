using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemsC_.Strings
{
    internal class ReverseInteger
    {
        public int Reverse(int value)
        {
            if (value == int.MinValue)
            {
                return 0;  // because reversing -2147483648 would result in out-of-bounds 8463847412
            }
            bool isNegative = value < 0;

            if (isNegative)
            {
                value = -value;
            }

            char[] chars = value.ToString().ToCharArray();
            Array.Reverse(chars);
            string reversedStr = new string(chars);

            long reversedLong = long.Parse(reversedStr);  // Use long to handle larger numbers temporarily

            // Check if the reversed value is out of int range
            if (reversedLong > int.MaxValue || reversedLong < int.MinValue)
            {
                return 0;
            }

            int reversedNumber = (int)reversedLong;  // It's safe to cast now

            if (isNegative)
            {
                reversedNumber = -reversedNumber;
            }

            return reversedNumber;
        }
    }
}
