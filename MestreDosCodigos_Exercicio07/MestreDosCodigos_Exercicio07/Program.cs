using System;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigos_Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Ler números inteiros e calcular os pares **");

            var listaNumerosInteiros = new List<int>();

            Console.Write("\nDigite o primeiro número inteiro: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            listaNumerosInteiros.Add(primeiroNumero);

            Console.Write("\nDigite o segundo número inteiro: ");
            int segundoNumero = int.Parse(Console.ReadLine());
            listaNumerosInteiros.Add(segundoNumero);

            Console.Write("\nDigite o terceiro número inteiro: ");
            int terceiroNumero = int.Parse(Console.ReadLine());
            listaNumerosInteiros.Add(terceiroNumero);

            Console.Write("\nDigite o quarto número inteiro: ");
            int quartoNumero = int.Parse(Console.ReadLine());
            listaNumerosInteiros.Add(quartoNumero);

            listaNumerosInteiros.RemoveAll(x => x % 2 != 0);

            int somaNumerosPares = listaNumerosInteiros.Sum();

            Console.WriteLine($"\nA soma dos números inteiros pares é: {somaNumerosPares}");

            
        }
    }
}
