using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{
    internal class Box
    {
        public int Height;
        public int Length;
        public int Width;



        public Box(int x)
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }

        public override string ToString()
        {
            return $"Height: {Height},Length:{Length}, Width:{Width}";
        }

    }
    internal class WoodenBox : Box {
        public int Area;
        public WoodenBox():base(1)
        {
            Console.WriteLine("Wooden BOX constuctor");
        }
        public WoodenBox(int x):base(x)
        {
            Console.WriteLine("Wooden BOX constuctor");
        }
       public WoodenBox(int x,int y):base(x)
        {
            Console.WriteLine("Wooden BOX constuctor");
        }

        public void Move()
        {
            Console.WriteLine("Wooden Box Shifted");
        }

        public override string ToString()
        {
            return "Tom and Jerry";
        }
    }
    internal class BoxTester
    {
        public static void TestOne()
        {
           Box box= new Box(100);
           
            box.Height = 10;
            box.Length = 5;
            box.Width = 20;
            box.Open();
            box.Close();
            box.ToString();
            String output=box.ToString();
            Console.WriteLine(output);
            Console.WriteLine('\n');


        }

        public static void TestTwo()
        {
           
            WoodenBox box = new WoodenBox();  //Two objects are created here for parent and child
            WoodenBox box1 = new WoodenBox(150);  //Two objects are created here for parent and child
            box.Height = 10;
            box.Length = 5;
            box.Width = 20;
            box.Open();
            box.Close();
            box.ToString();
            String output = box.ToString();
            Console.WriteLine(output);
            box.Area= 300;
            box.Move();
            Console.WriteLine('\n');


        }

        public static void TestThree()
        {
            Box box = new WoodenBox();  //Create a object of WoodenBox and assign its reference to the box variable which is of type Box

            box.Height = 10;
            box.Length = 5;
            box.Width = 20;
            box.Open();
            box.Close();
            box.ToString();
            String output = box.ToString();
            Console.WriteLine(output);
            


        }
    }
}