using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySix
{
    internal class WorkingWithObjects
    {
        public static void TestOne()
        {
            Object objectOne = new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");  // HashCode=> object is given a number in the heap
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");



            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }

        public static void TestTwo()
        {
            Emp empOne = new Emp();   
            empOne.ID = 1001;
            Emp empTwo = empOne;
            empOne.ID = 1001;
            Emp empThree = empOne;
            empOne.ID = 1001;
            bool flag = (empOne.Equals(empTwo));
            Console.WriteLine(flag);
            flag = empOne.Equals(empThree);
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());      //every object has a unique hashcode
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());

        }

        internal class Emp
        {
            public int ID;
            public string Name;
            public double Salary;
        }
    }
}
