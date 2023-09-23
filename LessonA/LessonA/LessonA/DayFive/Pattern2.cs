using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFive
{
    internal class Pattern2
    {
        public static void pattern()
        {
            int row = 5;
            for (int i = 1; i <= row; i++)
            {
                for (int j = row; j >= 1; j--)
                {
                    Console.Write("*");

                }
                row--;
                Console.WriteLine();
            }
        }
    }
 }

