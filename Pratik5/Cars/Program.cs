using System;

namespace Cars
{
    class Program
    {

        static void Main(string[] args)
        {
            Car crs = new Car();

            // nesnemize özellik değerlerini giriyoruz
            crs.speed = 217;
            crs.fuel = "Gasoline -";
            crs.color = "Red -";
            crs.brand = "Alfa Romeo -";



            crs.CarInfo();
            Console.ReadKey();
        }
        public class Car
        {
            public string fuel;
            public int speed;
            public string color;
            public string brand;

            public void CarInfo()
            {
                string cars = "Car Brand: " + brand + " Color: " + color + " Fuel Type: " + fuel + " Max Speed: " + speed;

                Console.WriteLine(cars);
            }
        }
    }
}
