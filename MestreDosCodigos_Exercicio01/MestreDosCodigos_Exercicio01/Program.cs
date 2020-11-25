using System;
using System.Globalization;
using System.Text;

namespace MestreDosCodigos_Exercicio01
{
    class Program
    {
        enum opcoes : int
        {
            Soma,
            Subtracao,
            Divisao,
            Multiplicacao,
            ParidadeDosValores,
            TodosOsResultados,
            TrocarValores
        }
        static void Main(string[] args)
        {
            Executar();
            Console.ReadKey();
        }

        static void Executar()
        {
            Console.WriteLine("** Manipulando variáveis **");
            Console.WriteLine("");

            double valorA = SolicitarValorA();
            double valorB = SolicitarValorB();

            opcoes opcaoSelecionada = Menu();

            Console.WriteLine("");

            switch (opcaoSelecionada)
            {
                case opcoes.Soma:
                    Console.WriteLine($"Resultado: {Somar(valorA, valorB)}");
                    break;
                case opcoes.Subtracao:
                    Console.WriteLine($"Resultado: {Subtrair(valorA, valorB)}");
                    break;
                case opcoes.Divisao:
                    Console.WriteLine($"Resultado: {Dividir(valorA, valorB)}");
                    break;
                case opcoes.Multiplicacao:
                    Console.WriteLine($"Resultado: {Multiplicar(valorA, valorB)}");
                    break;
                case opcoes.ParidadeDosValores:
                    ExibirParidadeDosValores(valorA, valorB);
                    break;
                case opcoes.TodosOsResultados:
                    ExibirTodosOsResultados(valorA, valorB);
                    break;
                case opcoes.TrocarValores:
                    Executar();
                    break;
            }
        }



        static opcoes Menu()
        {
            StringBuilder menu = new StringBuilder();

            menu.AppendLine("");
            menu.AppendLine("Selecione a opção desejada abaixo:");
            menu.AppendLine("1 - Somar valores (A + B)");
            menu.AppendLine("2 - Subtrair valores (A - B)");
            menu.AppendLine("3 - Dividir valores ( B / A)");
            menu.AppendLine("4 - Multiplicar valores (A * B)");
            menu.AppendLine("5 - Exibir os valores e suas respectivas paridades");
            menu.AppendLine("6 - Exibir todos os resultados das opções acima");
            menu.AppendLine("7 - Trocar os valores de A e B");
            menu.AppendLine("0 - Sair");

            Console.WriteLine(menu.ToString());

            int opcaoSelecionada = 0;

            opcaoSelecionada = int.Parse(Console.ReadLine());

            if (opcaoSelecionada == 0)
            {
                System.Environment.Exit(0);
            }

            if (opcaoSelecionada > 7 || opcaoSelecionada < 0)
            {
                Console.WriteLine("Opção inválida");
                throw new Exception();
            }

            opcaoSelecionada -= 1;
            return (opcoes)opcaoSelecionada;
        }

        static double SolicitarValorA()
        {
            Console.Write("Digite o valor de A: ");

            double valorA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return valorA;
        }

        static double SolicitarValorB()
        {
            Console.Write("Digite o valor de B: ");

            double valorB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return valorB;
        }

        static double Somar(double valorA, double valorB)
        {
            return (valorA + valorB);
        }

        static double Subtrair(double valorA, double valorB)
        {
            return (valorA - valorB);
        }

        static double Dividir(double valorA, double valorB)
        {
            return (valorB / valorA);
        }

        static double Multiplicar(double valorA, double valorB)
        {
            return valorA * valorB;
        }

        static void ExibirParidadeDosValores(double valorA, double valorB)
        {
            string paridadeA = "Ímpar";

            if (valorA % 2 == 0)
            {
                paridadeA = "Par";
            }

            Console.WriteLine($"Valor de A é {paridadeA}");

            string paridadeB = "Ímpar";

            if (valorB % 2 == 0)
            {
                paridadeB = "Par";
            }

            Console.WriteLine($"Valor de B é {paridadeB}");

        }

        static void ExibirTodosOsResultados(double valorA, double valorB)
        {
            Console.WriteLine($"Resultado da Soma: {Somar(valorA, valorB)}");
            Console.WriteLine($"Resultado da Subtração: {Subtrair(valorA, valorB)}");
            Console.WriteLine($"Resultado da Divisão: {Dividir(valorA, valorB)}");
            Console.WriteLine($"Resultado da Multiplicação: {Multiplicar(valorA, valorB)}");
            ExibirParidadeDosValores(valorA, valorB);
        }
    }
}
