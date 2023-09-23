using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFour
{
    public enum City { Chennai,Banglore,Hyderabad,Pune}

    public enum Designation { Manager,Admin,Developer}
    internal class Employee
    {
        public readonly int EiD;
        public string Ename;
        public City Ecity;
        public Designation JobTitle;


        public Employee(int v1) { EiD = v1; }

        public override string ToString()
        {
            String output = String.Empty;
            output = $"Details of a employee are: ID={EiD} Name={Ename} City={Ecity} JobTitle={JobTitle}";
            return output;

        }
    }

        class TestEmployee
        {
            public static void TestOne()
            {
                Employee e1 = new Employee(348);
                //e1.eid = 123;
                e1.Ename = "John";
                e1.Ecity = City.Banglore; //ecity = "Chennai";
                e1.JobTitle = Designation.Developer;//edept = "Testing";
                String output = e1.ToString();
                Console.WriteLine(output);
            }
        }

  
}
