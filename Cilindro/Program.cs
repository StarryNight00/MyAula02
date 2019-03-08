using System;

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
            //float pi = 3,1415926;

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

            //Área Superfícial

            //Print Resultados
        }
    }
}
