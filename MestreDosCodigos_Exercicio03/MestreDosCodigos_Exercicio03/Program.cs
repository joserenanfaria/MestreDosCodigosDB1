using System;

namespace MestreDosCodigos_Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("Todos os múltiplos de 3, entre 1 e 100:");

            while (i <= 100)
            {
                if((i % 3) == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            Console.ReadKey();
        }
    }
}
