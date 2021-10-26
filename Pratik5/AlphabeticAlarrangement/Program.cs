using System;

namespace AlphabeticAlarrangement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Word = ");

            string name = Convert.ToString(Console.ReadLine());

            int lenght = name.Length;

            char[] array = new char[lenght];

            string inLine = "Alphabetic Alarrangement = ";

            for (int i = 0; i < lenght; i++)
            {
                array[i] = name[i];
            }
            Array.Sort(array);

            for (int i = 0; i < lenght; i++)
            {
                inLine += array[i];
            }
            Console.WriteLine(inLine);
            Console.ReadLine();
        }
    }
}
