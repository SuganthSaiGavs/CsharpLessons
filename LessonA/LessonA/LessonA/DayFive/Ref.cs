using LessonA.DayFive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFive
{
    internal class Ref
    {
        public static void Dotask(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }

        public static void DotaskA(ref int x)  //x==v1   
         {
            int i = x + 2000;
            x=i;
            Console.WriteLine(x);

         }
    }
}
/*
Program.cs

int v1 = 1000;
Console.WriteLine($"v1:{v1}");
Ref.Dotask(v1);
Console.WriteLine($"v1:{v1}");   using ref keyword v1 is also changed without directlyn changing v1.
Ref.DotaskA(ref v1);
Console.WriteLine($"v1:{v1}");*/
