using System;
using System.Text;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCilindro");
            // Declarar as variáveis
            string altStr, radStr;
            float h, r;
            double volume, areaSup;

            //Input
            Console.WriteLine("Insira os valores para:\n");
            //Pedir altura e converter para Float/Double
            Console.WriteLine("Altura: ");
            altStr = Console.ReadLine();
            h = Convert.ToSingle(altStr);

            //Pedir raio e converter para Float/Double
            Console.WriteLine("Raio: ");
            radStr = Console.ReadLine();
            r = Convert.ToSingle(radStr);

            //Operações
            //Volume = pi*r^2*h
            volume = Math.PI * Math.Pow(r, 2) * h;

            //Área Superfícial = 2*pi*r(r+h)
            areaSup = 2 * Math.PI * r * (r + h);


            //Print Resultados
            Console.WriteLine($"\nO Cilindro apresentado tem:");
            Console.WriteLine($"Volume = {volume:f3};");
            Console.WriteLine("Área Superficial = {0:f3}.\n", areaSup);
        }
    }
}
