using System;
using System.Collections.Generic;

namespace MestreDosCodigos_Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Listagem de alunos com média maior que 7 **");

            var Alunos = new List<Aluno>();
            bool ContinuarAdicionandoAlunos = true;

            while (ContinuarAdicionandoAlunos)
            {
                Alunos.Add(SolicitarAluno());
                Console.WriteLine("");
                Console.WriteLine("Aluno adicionado!");

                ContinuarAdicionandoAlunos = validarSeContinuaAdicionandoAlunos();
            }

            Console.WriteLine("");
            Console.WriteLine("Alunos adicionados com sucesso!");

            Console.WriteLine("");
            Console.WriteLine("Alunos com média >= 7: ");

            foreach (Aluno aluno in Alunos)
            {
                if (aluno.CalcularMediaDasNotas() >= 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine(aluno);
                }
            }

            Console.ReadKey();
        }

        static Aluno SolicitarAluno()
        {
            Console.WriteLine("");
            Console.Write("Digite o NOME do aluno: ");
            string nomeAluno = Console.ReadLine();


            var notasAluno = new List<double>();
            bool ContinuaAdicionandoNotas = true;

            while (ContinuaAdicionandoNotas)
            {
                notasAluno.Add(SolicitarNotaAluno());
                Console.WriteLine("");
                Console.WriteLine("Nota adicionada!");

                ContinuaAdicionandoNotas = validarSeContinuaAdicionandoNotas();
            }

            Console.WriteLine("");
            Console.WriteLine($"Notas do aluno {nomeAluno} adicionadas com sucesso!");

            return new Aluno(nomeAluno, notasAluno);
        }

        static bool validarSeContinuaAdicionandoAlunos()
        {
            Console.WriteLine("");
            Console.Write("Deseja adicionar mais aluno (S/N)? ");
            string adicionarAlunos = Console.ReadLine().ToUpper();

            if ((!adicionarAlunos.Equals("S")) && (!adicionarAlunos.Equals("N")))
            {
                Console.WriteLine("");
                Console.WriteLine("Operação inválida - Digite a letra S para SIM ou a letra N para NÃO");
                validarSeContinuaAdicionandoAlunos();
            }

            return adicionarAlunos.Equals("S");
        }

        static bool validarSeContinuaAdicionandoNotas()
        {
            Console.WriteLine("");
            Console.Write("Deseja adicionar mais notas para o aluno (S/N)? ");
            string adicionarNotas = Console.ReadLine().ToUpper();

            if ((!adicionarNotas.Equals("S")) && (!adicionarNotas.Equals("N")))
            {
                Console.WriteLine("");
                Console.WriteLine("Operação inválida - Digite a letra S para SIM ou a letra N para NÃO");
                validarSeContinuaAdicionandoNotas();
            }

            return adicionarNotas.Equals("S");
        }


        static double SolicitarNotaAluno()
        {
            Console.WriteLine("");
            Console.Write("Digite a NOTA do aluno: ");
            var nota = double.Parse(Console.ReadLine());

            return nota;
        }
    }
}
