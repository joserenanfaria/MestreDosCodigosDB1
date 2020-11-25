using System;
using System.Collections.Generic;
using System.Globalization;

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
                Console.WriteLine("\nAluno adicionado!");

                ContinuarAdicionandoAlunos = validarSeContinuaAdicionandoAlunos();
            }

            Console.WriteLine("\nAlunos adicionados com sucesso!");

            Console.WriteLine("\nAlunos com média >= 7: ");

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
            Console.Write("\nDigite o NOME do aluno: ");
            string nomeAluno = Console.ReadLine();


            var notasAluno = new List<double>();
            bool ContinuaAdicionandoNotas = true;

            while (ContinuaAdicionandoNotas)
            {
                notasAluno.Add(SolicitarNotaAluno());
                Console.WriteLine("\nNota adicionada!");

                ContinuaAdicionandoNotas = validarSeContinuaAdicionandoNotas();
            }
            Console.WriteLine($"\nNotas do aluno {nomeAluno} adicionadas com sucesso!");

            return new Aluno(nomeAluno, notasAluno);
        }

        static bool validarSeContinuaAdicionandoAlunos()
        {
            Console.Write("\nDeseja adicionar mais alunos (S/N)? ");
            return Console.ReadLine().ToUpper().Equals("S");
        }

        static bool validarSeContinuaAdicionandoNotas()
        {
            Console.Write("\nDeseja adicionar mais notas para o aluno (S/N)? ");
            return Console.ReadLine().ToUpper().Equals("S");
        }


        static double SolicitarNotaAluno()
        {
            Console.Write("\nDigite a NOTA do aluno: ");
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}
