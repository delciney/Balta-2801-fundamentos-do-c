﻿using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploMetodosAdicionais();
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

        static void ExemploComparacaoDeStrings()
        {
            var texto = "Testando";

            Console.WriteLine(texto.CompareTo("Testando")); // retorna 0 se encontrar 
            Console.WriteLine(texto.CompareTo("testando")); // retorna 1 se não encontrar 

            Console.WriteLine(texto.Contains("Testando")); // retorna true se encontrar 
            Console.WriteLine(texto.Contains("testando")); // retorna false se não encontrar 
            Console.WriteLine(texto.Contains(
                "testando", 
                StringComparison.OrdinalIgnoreCase)
                ); // não diferencia maiusculo de minusculo 

        }

        static void ExemploStartWithEndsWith()
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.StartsWith("Este")); // retorna true se encontrar 
            Console.WriteLine(texto.StartsWith("este")); // retorna false se não encontrar
            Console.WriteLine(texto.StartsWith(
                "este",
                StringComparison.OrdinalIgnoreCase
                )); // não diferencia maiusculo de minusculo 

            Console.WriteLine(texto.EndsWith("teste")); // retorna true se encontrar 
            Console.WriteLine(texto.EndsWith("Teste")); // retorna false se não encontrar
            Console.WriteLine(texto.EndsWith(
                "Teste",
                StringComparison.OrdinalIgnoreCase
                )); // não diferencia maiusculo de minusculo 
        }

        static void ExemploEquals()
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.Equals("Este texto é um teste")); // retorna true se encontrar 
            Console.WriteLine(texto.Equals("este texto é um teste")); // retorna false se não encontrar
            Console.WriteLine(texto.Equals(
                "este texto é um teste",
                StringComparison.OrdinalIgnoreCase
                )); // não diferencia maiusculo de minusculo 
        }

        static void ExemploIndices()
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.IndexOf("é")); // retorna a posição na string (11) se encontrar
            Console.WriteLine(texto.IndexOf("É")); // retorna -1 se não encontrar
            Console.WriteLine(texto.IndexOf(
                "É", 
                StringComparison.OrdinalIgnoreCase
                )); // não diferencia maiusculo de minusculo

            Console.WriteLine(texto.LastIndexOf("s")); // retorna a posição na string (11) se encontrar
            Console.WriteLine(texto.LastIndexOf("S")); // retorna -1 se não encontrar
            Console.WriteLine(texto.LastIndexOf(
                "S",
                StringComparison.OrdinalIgnoreCase
                )); // não diferencia maiusculo de minusculo

        }

        static void ExemploMetodosAdicionais()
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.ToLower()); // Converte para minúsculo
            Console.WriteLine(texto.ToUpper()); // Converte para maiúsculo

            Console.WriteLine(texto.Insert(5, "AQUI ")); // Adiciona uma string em um indice determinado
            Console.WriteLine(texto.Remove(5, 5)); // Remove uma string em um indice determinado

            Console.WriteLine(texto.Length); // Retorna a quantidade de caracteres (21)
        }
    }
}
