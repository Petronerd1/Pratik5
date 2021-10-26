using System;

namespace SanslıSayiSansliGün
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Random r = new Random();
            Console.WriteLine("Enter your Name and Surname");
            string ad = Console.ReadLine();
            Console.WriteLine(" {0} ", ad);
            Console.WriteLine("Lucky Day {0} => ", days[r.Next(6)]);
            Console.WriteLine("Lucky Number {0} => ", r.Next(1, 99));
            Console.ReadLine();
        }
    }
}
