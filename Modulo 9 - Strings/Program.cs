﻿using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploInterpolacaoDeStrings();
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

        static void ExemploInterpolacaoDeStrings()
        {
            var price = 10.2;
            //var texto = "O preço do produto é " + price + " na promoção";

            //var texto = string.Format("O preço do produto é {0} apenas na promoção", price);

            var texto = @$"O preço do produto é {price} 
                           apenas na promoção";

            Console.WriteLine(texto);
        }
    }
}
