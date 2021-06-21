using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Multiplicacao();
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();

        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            if(v1 == 0 || v2 == 0)
            {
                Console.WriteLine("impossivel dividir por 0");
                return;
            }

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
        }
    }
}
