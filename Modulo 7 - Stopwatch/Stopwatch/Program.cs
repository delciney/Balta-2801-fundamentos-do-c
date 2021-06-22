using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos -> 10s = 10 segundos");
            Console.WriteLine("M = Minutos -> 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();

            if(data.Length <= 0 || (data.Length == 1 && data != "0"))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido tente novamente");
                Thread.Sleep(1000);
                Menu();
            }


            if (data == "0")
                System.Environment.Exit(0);

            int time = int.Parse(data.Substring(0, data.Length - 1));
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int multiplier = 1;

            if (time == 'm')
                multiplier = 60;

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();

            Console.WriteLine("Ready...");
            Thread.Sleep(1000);

            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
