using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.InnerClasses
{
    internal class CarForInner
    {
        public int carNumber=20;
        public string RegistrationNo { get; set; }
        public string Model { get; set; }
        public FuelType CarFuelType { get; set; }
        public Wheel[] Wheels { get; } = new Wheel[4];
        public Engine CarEngine { get; set; }
        public CarForInner(string registrationNo, string model, FuelType fuelType)
        {
            RegistrationNo = registrationNo;
            Model = model;
            CarFuelType = fuelType;



            for (int i = 0; i < 4; i++)
            {
                Wheels[i] = new Wheel();
            }



            CarEngine = new Engine();
        }



        public enum FuelType
        {
            Petrol,
            Diesel,
            Electric,
            Hybrid
        }



        public class Wheel
        {
            public int number = 10;
            // Wheel properties and methods can be added here
        }



        public class Engine
        {
            // Engine properties and methods can be added here
        }
    }



   /* class Program
    {
        public static void TestMethod()
        {
            Car car = new Car("101", "Sedan", Car.FuelType.Petrol);



            Console.WriteLine($"Registration No: {car.RegistrationNo}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Fuel Type: {car.CarFuelType}");
        }
    }*/
}


