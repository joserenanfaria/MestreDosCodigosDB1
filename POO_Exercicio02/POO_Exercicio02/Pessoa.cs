using System;

namespace POO_Exercicio02
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public double Altura { get; private set; }

        public Pessoa(string nome, DateTime dataNascimento, double altura)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }

        public int CalcularIdade() =>
            DateTime.Now.Year - DataNascimento.Year;

        public string ImprimirDados() =>
            $"Dados Pessoa: \nNome: {Nome} \nData Nascimento: {DataNascimento:dd/MM/yyyy} \nAltura: {Altura}";
    }
}
