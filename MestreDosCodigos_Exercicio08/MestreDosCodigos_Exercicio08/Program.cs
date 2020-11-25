using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MestreDosCodigos_Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Ler N valores decimais e ordernar crescente e decrescente **");

            var listaNumerosDecimais = new List<decimal>();

            bool continuarAdicinando = true;


            while (continuarAdicinando)
            {
                Console.Write("\nDigite o valor decimal para ordenação: ");

                decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaNumerosDecimais.Add(valor);

                Console.WriteLine("\nValor adicionado!");

                continuarAdicinando = validarSeContinuaAdicionandoValores();
            }

            Console.Write("\nValores em ordem crescente: \n");
            listaNumerosDecimais = listaNumerosDecimais.OrderBy(x => x).ToList();
            listaNumerosDecimais.ForEach(Console.WriteLine);

            Console.Write("\nValores em ordem decrescente: \n");
            listaNumerosDecimais = listaNumerosDecimais.OrderByDescending(x => x).ToList();
            listaNumerosDecimais.ForEach(Console.WriteLine);

            Console.ReadKey();
        }

        private static bool validarSeContinuaAdicionandoValores()
        {
            Console.Write("\nDeseja adicionar mais valores (S/N)? ");
            return Console.ReadLine().ToUpper().Equals("S");
        }
    }
}
