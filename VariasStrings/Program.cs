using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Exercício 1");
            string s1 = "My name is \t, what is yours,\n my friend?";
            string s2 = @"My name is \t, what is yours,\n my friend?";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("\n\nExercício 2");

            Console.WriteLine("\n\nExercício 3");
            double xx = 0.12345;
            int ii = 18;

            string s9 = $"{xx:f2}";
            string s10 = $"{xx:p1}";
            string s11 = $"{ii:x}";
            string s12 = $"{ii:c}";

            Console.WriteLine(s9);
            Console.WriteLine(s10);
            Console.WriteLine(s11);
            Console.WriteLine(s12);
        }
    }
}
