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

                Console.WriteLine("");
                Console.WriteLine("Funcionário adicionado!");

                continuarAdicinando = validarSeContinuaAdicionandoFuncionario();
            }

            Console.WriteLine("");
            Console.WriteLine("Resultados:");
            ExibirFuncionarioComMaiorSalario(listaFuncionarios);
            ExibirFuncionarioComMenorSalario(listaFuncionarios);

            Console.ReadKey();

        }

        private static bool validarSeContinuaAdicionandoFuncionario()
        {
            Console.WriteLine("");
            Console.Write("Deseja adicionar mais funcionários (S/N)? ");
            string adicionarMaisFuncionarios = Console.ReadLine().ToUpper();            

            if ((!adicionarMaisFuncionarios.Equals("S")) && (!adicionarMaisFuncionarios.Equals("N")))
            {
                Console.WriteLine("Operação inválida - Digite a letra S para SIM ou a letra N para NÃO");
                validarSeContinuaAdicionandoFuncionario();
            }

            return adicionarMaisFuncionarios.Equals("S");
        }

        static void ExibirFuncionarioComMaiorSalario(List<Funcionario> listaFuncionarios)
        {
            var funcionarioComMaiorSalario = VerificarFuncionarioComMaiorSalario(listaFuncionarios);

            Console.WriteLine("Funcionário com maior salario é o {0} com salário de R$ {1}",
                funcionarioComMaiorSalario.Nome,
                funcionarioComMaiorSalario.Salario.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void ExibirFuncionarioComMenorSalario(List<Funcionario> listaFuncionarios)
        {
            var funcionarioComMenorSalario = VerificarFuncionarioComMenorSalario(listaFuncionarios);

            Console.WriteLine("Funcionário com menor salario é o {0} com salário de R$ {1}",
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
            Console.WriteLine("");
            Console.Write("Digite o nome do funcionário: ");
            string nomeFuncionario = Console.ReadLine();

            return nomeFuncionario;
        }

        static double SolicitarSalarioFuncionario()
        {
            Console.Write("Digite o salário do funcionário: ");
            double salarioFuncionario = 0;

            try
            {
                salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                Console.WriteLine("Valor inválido - refaça a operação");
                SolicitarSalarioFuncionario();
            }           

            return salarioFuncionario;
        }
    }
}
