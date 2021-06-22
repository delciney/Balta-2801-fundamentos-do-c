using System;
using System.IO;

namespace TextEditor
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

            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }
        static void Open() 
        {
            Console.Clear();

        }
        static void Edit() 
        {
            Console.Clear();

        }
        static void Save() 
        {
            Console.Clear();

        }
    }
}
