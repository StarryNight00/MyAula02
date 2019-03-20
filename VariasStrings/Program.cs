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
            string s1 = "My name is \t, what is yours,\n my friend? \u263A";
            string s2 = @"My name is \t, what is yours,\n my friend? \u263A";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("\n\nExercício 2");
            int t = 0;
            int x = 2;
            string y = "papagaio";
            string w = "verde";
            string z = "azul";

            string s3 = String.Format("\nIsto é x = {0} e isto é y = {1}", x, y);
            string s4 = String.Format("\nEspero que todos saibam que {1} + {0} continua a ser {1}\n", t, x);

            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine("O céu é {0}", w);
            Console.WriteLine($"\tMas dizem que pode ser {w + z}");
            Console.WriteLine($@"\nJá um {y + z} é algo que nunca vi.");

            Console.WriteLine("\n\nExercício 3");
            double xx = 0.12345;
            int ii = 18;

            string s6 = "lolipop";
            string s9 = $"{xx:f2}";
            string s10 = $"{xx:p1}";
            string s11 = $"{ii:x}";
            string s12 = $"{ii:c}";

            Console.WriteLine("...{0,15:f2}...", 160);
            Console.WriteLine("...{0,-15:f2}...", s6);
            Console.WriteLine(s9);
            Console.WriteLine(s10);
            Console.WriteLine(s11);
            Console.WriteLine(s12);

            Console.WriteLine("\n\nExercício 4 - bit a bit");
            Console.WriteLine("\n1) x = i1 - 13 <=> x = 3 -(-8) = 11");
            Console.WriteLine("\n2) x = i3 / i1 <=> x = -8 / 3 <=> x = -2");
            Console.WriteLine("\n3) x += i2 <=> 2 += 1 = 3");
            Console.WriteLine("\n4) x *= i1 <=> 2 *= 3 = 6");
            Console.WriteLine("\n5) x %= i2 - 0b1001 <=> 2 %= 1 - 9 <=> 2 %= -8 = 2");
            Console.WriteLine("\n6) x = i1 (3 = 0011) << 2 <=> x = 1100 = 12 = 'C'");
            Console.WriteLine("\n7) x << = x <=> 0010 << = 2 <=> 1000 <=> 8");
            Console.WriteLine("\n8) x &= 0x21AD ^ i1 = 0010 = 2");
            Console.WriteLine("\n9) x = ~(i1(3=0010)|i3(-8=1110)) = 0");

            Console.WriteLine("\n\nExercício 5 - booleanos");
            Console.WriteLine("\n1) x = && false --> F");
            Console.WriteLine("\n2) F");
            Console.WriteLine("\n3) T");
            Console.WriteLine("\n4) x &= f2 < f1 <=> x &= true --> T");
            Console.WriteLine("\n5) x ^= !(f2 != f1) x ^= !(true) <=> true ^= false --> T");
            Console.WriteLine("\n6) x |= !true ^ b1 <=> x |= false ^ true <=> x |= true --> T");
            Console.WriteLine("\n7) F");
            Console.WriteLine("\n8) T");
            Console.WriteLine("\n9) T");
        }
    }
}
