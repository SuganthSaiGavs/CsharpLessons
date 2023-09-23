using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LessonA.Day_Two
{
    internal class DemoA
    {
        //GLOBAL DECLARATION
        int x = 123; //Member variable / Class variable / field
        static int y = 567;
        public static void FirstMethod()
        {
            //LOCAL VARIABLES
            int y = 2000;
            //Console.WriteLine(x); //NON STATIC VARIABLE can not be accessed
            Console.WriteLine(y); //Local Variables
            Console.WriteLine(DemoA.y);  //Global Static Variable
        }

        public void SecondMethod()  //non-static method
        {
            int y = 5000;
            Console.WriteLine(x); //   NON STATIC MEMBER can be accessed
            Console.WriteLine(y);  // local variable
            Console.WriteLine(DemoA.y); //global static variable
        }
    }

    internal class DemoB
    {

    }
}

namespace LessonA.GAVS
{
    internal class DemoA
    {

    }
}
