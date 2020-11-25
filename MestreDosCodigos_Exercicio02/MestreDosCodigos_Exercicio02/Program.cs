using System;
using System.Collections.Generic;
using System.Globalization;

namespace MestreDosCodigos_Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Maior e menor salário de funcionário(s) **");

            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            bool continuarAdicinando = true;


            while (continuarAdicinando)
            {

                listaFuncionarios.Add(new Funcionario(SolicitarNomeFuncionario(), SolicitarSalarioFuncionario()));

                Console.WriteLine("\nFuncionário adicionado!");

                continuarAdicinando = validarSeContinuaAdicionandoFuncionario();
            }

            Console.WriteLine("\nResultados:");
            ExibirFuncionarioComMaiorSalario(listaFuncionarios);
            ExibirFuncionarioComMenorSalario(listaFuncionarios);

            Console.ReadKey();
        }

        private static bool validarSeContinuaAdicionandoFuncionario()
        {
            Console.Write("\nDeseja adicionar mais funcionários (S/N)? ");
            return Console.ReadLine().ToUpper().Equals("S");
        }

        static void ExibirFuncionarioComMaiorSalario(List<Funcionario> listaFuncionarios)
        {
            var funcionarioComMaiorSalario = VerificarFuncionarioComMaiorSalario(listaFuncionarios);

            Console.WriteLine("\nFuncionário com maior salario é o {0} com salário de R$ {1}",
                funcionarioComMaiorSalario.Nome,
                funcionarioComMaiorSalario.Salario.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void ExibirFuncionarioComMenorSalario(List<Funcionario> listaFuncionarios)
        {
            var funcionarioComMenorSalario = VerificarFuncionarioComMenorSalario(listaFuncionarios);

            Console.WriteLine("\nFuncionário com menor salario é o {0} com salário de R$ {1}",
                funcionarioComMenorSalario.Nome,
                funcionarioComMenorSalario.Salario.ToString("F2", CultureInfo.InvariantCulture));
        }

        static Funcionario VerificarFuncionarioComMaiorSalario(List<Funcionario> listaFuncionarios)
        {
            int idxFuncionarioComMaiorSalario = 0;

            for (int i = 0; i < listaFuncionarios.Count; i++)
            {
                if (i - 1 > -1)
                {
                    if (listaFuncionarios[i].CompareTo(listaFuncionarios[i - 1]) > 0)
                    {
                        idxFuncionarioComMaiorSalario = i;
                    }
                }
            }

            return listaFuncionarios[idxFuncionarioComMaiorSalario];
        }

        static Funcionario VerificarFuncionarioComMenorSalario(List<Funcionario> listaFuncionarios)
        {
            int idxFuncionarioComMenorSalario = 0;

            for (int i = 0; i < listaFuncionarios.Count; i++)
            {
                if (i - 1 > -1)
                {
                    if (listaFuncionarios[i].CompareTo(listaFuncionarios[i - 1]) < 0)
                    {
                        idxFuncionarioComMenorSalario = i;
                    }
                }
            }

            return listaFuncionarios[idxFuncionarioComMenorSalario];
        }

        static string SolicitarNomeFuncionario()
        {
            Console.Write("\nDigite o nome do funcionário: ");
            return Console.ReadLine();
        }

        static double SolicitarSalarioFuncionario()
        {
            Console.Write("\nDigite o salário do funcionário: ");
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}
