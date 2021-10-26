using System;

namespace ClassCift
{
    class Program
    {
        private int Max(int[] numbers)
        {
            int Large = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Large < numbers[i]&&numbers[i]%2==0)
                {
                    Large = numbers[i];
                }
            }
            return Large;
        }
        static void Main(string[] args)
        {
            int[] num = new int[20];
            Random rnd = new Random();
            for(int i=0; i<num.Length;i++)
            {
                num[i] = rnd.Next(0, 100);
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("________________________");
            Program b = new Program();
            int largeNum = b.Max(num);
            if(largeNum !=0)
            {
                Console.WriteLine("Largest Number ={0}", b.Max(num));
            }
            else
            {
                Console.WriteLine("No even numbers");
            }
            Console.WriteLine("___________________________");
            Console.ReadKey();
        }
    }
}
