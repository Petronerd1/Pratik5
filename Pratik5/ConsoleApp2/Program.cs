using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrangle quadrangle = new Quadrangle();
            quadrangle.ShortEdgeLenght = 200;
            quadrangle.LongEdgeLenght = 200;
            Console.WriteLine("Edge Lenght = {0}x{1}",
            quadrangle.ShortEdgeLenght, quadrangle.LongEdgeLenght);
            Console.WriteLine("Quadrangle Type : {0}", quadrangle.QuadrangleType);

            Quadrangle dortgeniki = new Quadrangle();
            dortgeniki.ShortEdgeLenght = 100;
            dortgeniki.LongEdgeLenght = 350;
            Console.WriteLine("Edge Lenght = {0}x{1}",
            dortgeniki.ShortEdgeLenght, dortgeniki.LongEdgeLenght);
            Console.WriteLine("Quadrangle Type : {0}", dortgeniki.QuadrangleType);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
    class Quadrangle
    {
        private int shortEdgeLenght;
        private int longEdgeLenght;
        public int ShortEdgeLenght
        {
            get { return shortEdgeLenght; }
            set { shortEdgeLenght = value; }
        }

        public int LongEdgeLenght
        {
            get { return longEdgeLenght; }
            set { longEdgeLenght = value; }
        }
        public string QuadrangleType
        {
            get
            {
                string type = "";
                if (shortEdgeLenght == longEdgeLenght)
                    type = "Square";
                else
                    type = "Rectangle";
                return type;
            }
        }
    }
}
