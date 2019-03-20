using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //int
            Console.WriteLine("Max de int é " + int.MaxValue + " e o min é" + int.MinValue);


            //double
            double x1 = double.PositiveInfinity;
            double x2 = double.NegativeInfinity;
            Console.WriteLine("\nMax de double é "+ double.MaxValue + " e o min é" + double.MinValue);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            //float
            float f1 = float.PositiveInfinity;
            float f2 = float.NegativeInfinity;
            Console.WriteLine("\nMax de float é " + float.MaxValue + " e o min é" + float.MinValue);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
        }
    }
}
