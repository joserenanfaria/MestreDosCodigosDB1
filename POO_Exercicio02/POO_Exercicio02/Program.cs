using System;

namespace POO_Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaTeste = new Pessoa("José", new DateTime(1992, 02, 19), 1.91);

            Console.WriteLine(pessoaTeste.ImprimirDados());
            Console.WriteLine($"\nTeste método idade: {pessoaTeste.CalcularIdade()}");
        }
    }
}
