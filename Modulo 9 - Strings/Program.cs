using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploGuids();
        }

        static void ExemploGuids()
        {
            var id = Guid.NewGuid();

            // errado
            //id = new Guid("");

            // correto
            //id = new Guid("15942b04-5b6b-424d-8d64-4ff3170e3849");

            //id = new Guid();
            // retorna 00000000-0000-0000-0000-000000000000

            Console.WriteLine(id);
        }
    }
}
