using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day_Two
{
    internal class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }=string.Empty;
        public int ModelYear { get; set; }
        public string CarDescription { get; set; } = string.Empty;
        public string CarStatus { get; set; } = string.Empty;
        public int CarPrice { get; set; }

        public override string ToString()
        {
            return $"CarId:{CarId},Car Name:{this.CarName},ModelYear:{ModelYear},\n"+
               $" CarDescription:{ CarDescription},CarStatus:{CarStatus},CarPrice:{CarPrice}";
        }


    }

    internal class TestCar
    {
        public static void TestOne()
        {
            Car car1 = new Car();
            car1.CarId = 101;
            car1.CarName = "BMW";
            car1.ModelYear = 2023;
            car1.CarDescription = "4 seater, race type car ";
            car1.CarStatus = "New";
            car1.CarPrice = 4000000;
            string value = car1.ToString();
            Console.WriteLine(value);



        }
    }
}
