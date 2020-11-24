
using System;

namespace MestreDosCodigos_Exercicio02
{
    class Funcionario : IComparable
    {
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Erro ao comparar objetos: Argumento não é um funcionário");
            }

            Funcionario funcionarioComparacao = obj as Funcionario;

            return Salario.CompareTo(funcionarioComparacao.Salario);
            
        }
    }
}
