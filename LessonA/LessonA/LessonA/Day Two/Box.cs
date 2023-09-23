using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day_Two
{
    internal class Box
    {
        public static int height;
        public const string type= "wooden";
        public  int width;   //ONLY NON STATIC VARIABLES can be accessed using the objects.
        public int GetHeight() { return height; }
    }
    
    internal class TestBox
    {
        public static void TestOne()
        {
            Box.height = 100;
            Box firstBox = new Box();
            Box secondBox = new Box();
            firstBox.width = 12345;
            secondBox.width = 98765;

            Console.WriteLine($"First Box={firstBox.width},{firstBox.GetHeight()}");
            Console.WriteLine($"Second Box={secondBox.width},{secondBox.GetHeight()}");
            Console.WriteLine(Box.type);

        }
    }
}
