using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LessonA.DayOne
{
    /// <summary>
    /// 
    /// </summary>
    internal class ValueTypeLesson
    {
        public static void TestValueTypes()
        {
            byte b1 = 128;
            Console.WriteLine(b1);
            Console.WriteLine("Byte:");
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            float f1 = 52.678f;
            long l1 = int.MaxValue + 1000l;
            double d1 = 33333333333333333333d;
            Console.WriteLine(f1 + l1 + d1);

            char c1 = 'S';
            Console.WriteLine(c1);
            int x = c1;
            Console.WriteLine(x);


        }

        public static void TestMethod()    //Method declaration
        {
            Console.WriteLine("Test");
        }

    }
}
