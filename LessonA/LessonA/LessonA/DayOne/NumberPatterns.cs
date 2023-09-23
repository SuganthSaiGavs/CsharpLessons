using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayOne
{
    internal class NumberPatterns
    {
        public static int Patterns()
        {
            int n = 5; // Number of rows

            for (int i = 1; i <= n; i++)
            {
                // Print ascending numbers
                for (int j = i; j < 2 * i; j++)
                {
                    Console.Write(j);
                }

                // Print descending numbers 
                for (int j = 2 * i - 2; j >= i; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
            return 0;
        }
    }
}

