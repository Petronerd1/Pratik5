using System;

namespace ClassCircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius;
            Circle circle = new Circle();

            Console.Write("Enter circle radius :");
            radius = Convert.ToInt32(Console.Read());
            Console.WriteLine("Circle Area : {0:F2}", circle.Area(radius));
            Console.WriteLine("Circle Perimeter : {0:F2}", circle.Perimeter(radius));
            Console.ReadKey();

        }
        public class Circle
        {
            public float Area(float r)
            {
                return Convert.ToSingle(Math.PI * r * r);
            }
            public float Perimeter(float r)
            {
                return Convert.ToSingle(2 * Math.PI * r);
            }
        }
    }
}
