using System;

namespace POO_Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEspecial contaEspecial = new ContaEspecial("0001", 300, 1500);

            Console.WriteLine($"Informações iniciais conta especial {contaEspecial.NumeroDaConta}");

            Console.WriteLine("\n" + contaEspecial.MostrarDados());
            Console.WriteLine("\nDepositar 100,00 R$");
            contaEspecial.Depositar(100);
            Console.WriteLine("\n" + contaEspecial.MostrarDados());
            Console.WriteLine("\nSacar 900,00 R$");
            contaEspecial.Sacar(900);
            Console.WriteLine("\n" + contaEspecial.MostrarDados());

            ContaCorrente contaCorrente = new ContaCorrente("0002", 800, 10);

            Console.WriteLine($"\nInformações iniciais conta corrente {contaCorrente.NumeroDaConta}");

            Console.WriteLine("\n" + contaCorrente.MostrarDados());
            Console.WriteLine("\nDepositar 100,00 R$");
            contaCorrente.Depositar(100);
            Console.WriteLine("\n" + contaCorrente.MostrarDados());
            Console.WriteLine("\nSacar 500,00 R$");
            contaCorrente.Sacar(500);
            Console.WriteLine("\n" + contaCorrente.MostrarDados());
        }
    }
}
