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
                    Console.WriteLine("Resultado: {0} ", Somar(valorA, valorB));
                    break;
                case opcoes.Subtracao:
                    Console.WriteLine("Resultado: {0} ", Subtrair(valorA, valorB));
                    break;
                case opcoes.Divisao:
                    Console.WriteLine("Resultado: {0} ", Dividir(valorA, valorB));
                    break;
                case opcoes.Multiplicacao:
                    Console.WriteLine("Resultado: {0} ", Multiplicar(valorA, valorB));
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

            try
            {
                opcaoSelecionada = int.Parse(Console.ReadLine());

                if (opcaoSelecionada == 0){
                    System.Environment.Exit(0);
                }

                if (opcaoSelecionada > 7 || opcaoSelecionada < 0)
                {
                    Console.WriteLine("Opção inválida - Tente novamente");
                    Console.WriteLine("");
                    Menu();
                }                
            }
            catch (FormatException)
            {
                Console.WriteLine("Opção inválida - Tente novamente");
                Console.WriteLine("");
                Menu();
            }
            opcaoSelecionada -= 1;
            return (opcoes)opcaoSelecionada;
        }

        static double SolicitarValorA()
        {
            Console.Write("Digite o valor de A: ");
            double valorA = 0.0;
            try
            {
                valorA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor A inválido - Tente novamente");
                Console.WriteLine("");
                SolicitarValorA();
            }

            return valorA;
        }

        static double SolicitarValorB()
        {
            Console.Write("Digite o valor de B: ");
            double valorB = 0.0;
            try
            {
                valorB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor B inválido - Tente novamente");
                Console.WriteLine("");
                SolicitarValorB();
            }

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

            Console.WriteLine("Valor de A é {0}", paridadeA);

            string paridadeB = "Ímpar";

            if (valorB % 2 == 0)
            {
                paridadeB = "Par";
            }

            Console.WriteLine("Valor de B é {0}", paridadeB);

        }

        static void ExibirTodosOsResultados(double valorA, double valorB)
        {
            Console.WriteLine("Resultado da Soma: {0} ", Somar(valorA, valorB));
            Console.WriteLine("Resultado da Subtração: {0} ", Subtrair(valorA, valorB));
            Console.WriteLine("Resultado da Divisão: {0} ", Dividir(valorA, valorB));
            Console.WriteLine("Resultado da Multiplicação: {0} ", Multiplicar(valorA, valorB));
            ExibirParidadeDosValores(valorA, valorB);
        }
    }
}
