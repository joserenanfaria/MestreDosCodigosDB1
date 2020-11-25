using System;

namespace MestreDosCodigos_Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Calcular fórmula de Bhaskara **");

            Console.WriteLine("");
            Console.Write("Insira o valor de A: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Insira o valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Insira o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Resultados: ");

            double delta = Math.Pow(b, 2) - ((4 * a) * c);
            Console.WriteLine("");
            Console.WriteLine($"Valor de delta: {delta}");

            double raizDeDelta = Math.Sqrt(delta);
            Console.WriteLine("");
            Console.WriteLine($"Valor da raiz quadrada de delta: {raizDeDelta}");

            var x1 = ((-b) + raizDeDelta) / (2 * a);            

            Console.WriteLine("");
            Console.WriteLine($"Valor de x1: {x1}");

            var x2 = ((-b) - raizDeDelta) / (2 * a);

            Console.WriteLine("");
            Console.WriteLine($"Valor de x2: {x2}");
        }
    }
}
