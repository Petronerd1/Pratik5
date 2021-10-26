using System;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation plus = new Operation();
            plus.Result(plus.Addition(34,87));
            Operation minus = new Operation();
            minus.Result(minus.Extraction(34, 42));
            Operation x = new Operation();
            x.Result(x.Multiplication(88, 56));
            Operation slash = new Operation();
            slash.Result(slash.Division(782, 12));
            Console.ReadKey();
        }
        public class Operation
        {
            public int Addition(int num1, int num2)
            {
                return num1 + num2;
            }
            public int Extraction(int num1,int num2)
            {
                return num1 - num2;
            }
            public int Multiplication(int num1, int num2)
            {
                return num1 * num2;
            }
            public int Division(int num1, int num2)
            {
                return num1 / num2;
            }
            public void Result(int info)
            {
                Console.WriteLine("Operation Result {0}", info);
            }
        }
    }
}
