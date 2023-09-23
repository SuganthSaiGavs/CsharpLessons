using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemsC_.Strings
{
    internal class ReverseString
    {

        public static void Reverse(char[] s)
        {
            int firstPointer = 0;
            int lastpointer = s.Length - 1;

            while(firstPointer <= lastpointer)
            {
                char temp = s[firstPointer];
                s[firstPointer] = s[lastpointer];
                s[lastpointer] = temp;

                firstPointer++;
                lastpointer--;
            }
            //Console.WriteLine(s);
        }
           

      
    }
}
