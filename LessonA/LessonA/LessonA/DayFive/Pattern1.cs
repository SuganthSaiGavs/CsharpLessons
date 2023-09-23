using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFive
{/// <summary>
/// 1
/// 12
/// 123    Remove if loop to get this output.
/// 1234
/// 12345
/// </summary>
    internal class Pattern1
    {

        public static void pattern()
        {
            int row = 7;
            for (int i = 1; i <= row; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);

                    if (j == 3)
                    {
                        break;
                    }

                }
                Console.WriteLine();

            }
        }
    }
}
