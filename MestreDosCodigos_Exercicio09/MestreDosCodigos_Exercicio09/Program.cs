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
            Console.WriteLine(listaNumerosInteiros.FirstOrDefault());

            Console.WriteLine("\nImprimindo último item da lista");
            Console.WriteLine(listaNumerosInteiros.LastOrDefault());

            listaNumerosInteiros.Insert(0, 14);
            Console.WriteLine("\nImprimindo itens da lista depois de adicionar um valor no início da lista \n");
            listaNumerosInteiros.ForEach(Console.WriteLine);

            listaNumerosInteiros.Add(21);
            Console.WriteLine("\nImprimindo itens da lista depois de adicionar um valor no final da lista \n");
            listaNumerosInteiros.ForEach(Console.WriteLine);

            listaNumerosInteiros.Remove(listaNumerosInteiros.FirstOrDefault());
            Console.WriteLine("\nImprimindo itens da lista depois de remover primeiro valor da lista \n");
            listaNumerosInteiros.ForEach(Console.WriteLine);

            listaNumerosInteiros.Remove(listaNumerosInteiros.LastOrDefault());
            Console.WriteLine("\nImprimindo itens da lista depois de remover último valor da lista \n");
            listaNumerosInteiros.ForEach(Console.WriteLine);

            Console.WriteLine("\nImprimindo itens pares");
            listaNumerosInteiros.Where(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);

            int valorSelect = 19;
            Console.WriteLine($"\nImprimindo valor informado: {valorSelect}");
            listaNumerosInteiros.Where(x => x == valorSelect).ToList().ForEach(Console.WriteLine);

            Console.WriteLine();

            int[] arr = listaNumerosInteiros.ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Array posição {i}: {arr[i]}");
            }
     
            
            Console.ReadKey();

        }
    }
}
