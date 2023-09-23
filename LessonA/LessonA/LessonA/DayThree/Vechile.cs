using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{   //abstract class cannot be inherited
    /// <summary>
    /// abstract class need not be instansiated
    /// abstract class need not have abstract method(It is not compulsory)
    /// </summary>

    internal abstract class Vechile
    {
        public Vechile() 
        {
            Console.WriteLine("Vechile Constructor");
        }
        public void Start()
        {
            Console.WriteLine("Vechile Started");
        }
    }

    internal class Car: Vechile
    {
        public Car()
        {
            Console.WriteLine("Car Constructor");
        }

        public void Start()
        {
            Console.WriteLine("Car Started");
        }
    }

    class VechileTester
    {
        public static void TestOne() 
        {
            Vechile tester = new Car();
            tester.Start(); 
        }
    }


}
