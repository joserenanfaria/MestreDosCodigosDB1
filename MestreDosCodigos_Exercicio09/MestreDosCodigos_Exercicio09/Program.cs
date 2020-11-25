using System;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigos_Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Manuseando Listas com LINQ **");

            var listaNumerosInteiros = new List<int>() { 1, 7, 19, 35, 2, 3 };

            Console.WriteLine("\nImprimindo itens da lista \n");
            listaNumerosInteiros.ForEach(Console.WriteLine);

            Console.WriteLine("\nImprimindo itens da lista na ordem crescente \n");
            var listaNumerosInteirosAscendente = listaNumerosInteiros.OrderBy(x => x).ToList();
            listaNumerosInteirosAscendente.ForEach(Console.WriteLine);

            Console.WriteLine("\nImprimindo itens da lista na ordem decrescente \n");
            var listaNumerosInteirosDecrescente = listaNumerosInteiros.OrderByDescending(x => x).ToList();
            listaNumerosInteirosDecrescente.ForEach(Console.WriteLine);

            Console.WriteLine("\nImprimindo primeiro item da lista");
            Console.WriteLine(listaNumerosInteiros.First());

            Console.WriteLine("\nImprimindo último item da lista");
            Console.WriteLine(listaNumerosInteiros.Last());

            Console.ReadKey();

        }
    }
}
