using System;
using System.Globalization;
using System.Linq;

namespace MestreDosCodigos_Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Diferença entre os modificadores de parâmetro REF e OUT **");
           
            Console.Write("\nDigite seu nome com todas as letras em minúsculo: ");
            string nome = Console.ReadLine();

            PrimeirasLetrasEmMaiusculo(ref nome);

            Console.WriteLine("\nExemplo utilizando REF - Converter para maiúsculo:");

            Console.WriteLine($"\nSeu nome com a(s) primeira(s) letra(s) em maiúsculo: {nome}");

            Console.WriteLine("\nExemplo utilizando OUT - Inverter nome:");

            InverteNome(nome, out string nomeInvertido);

            Console.WriteLine($"\nSeu nome invertido: {nomeInvertido}");
        }

        public static void PrimeirasLetrasEmMaiusculo(ref string nome)
        {
            nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
        }

        public static void InverteNome(string nomeOriginal, out string nomeInvertido)
        {
            char[] arr = nomeOriginal.ToCharArray();
            Array.Reverse(arr);
            nomeInvertido = string.Join("", arr);
        }


    }
}
