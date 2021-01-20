using System;

namespace POO_Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {

            Televisao tv = new Televisao();
            ControleRemoto controle = new ControleRemoto(tv);

            Console.WriteLine($"Dados da TV:\nCanal:{controle.ConsultarCanal()} \nVolume:{controle.ConsultarVolume()}");

            Console.WriteLine("\nAumentando o volume");
            controle.AumentarVolume();
            Console.WriteLine($"\nDados da TV:\nCanal:{controle.ConsultarCanal()} \nVolume:{controle.ConsultarVolume()}");

            Console.WriteLine("\nDiminuindo o volume");
            controle.DiminuirVolume();
            Console.WriteLine($"\nDados da TV:\nCanal:{controle.ConsultarCanal()} \nVolume:{controle.ConsultarVolume()}");

            Console.WriteLine("\nAumentando o canal");
            controle.AumentarCanal();
            Console.WriteLine($"\nDados da TV:\nCanal:{controle.ConsultarCanal()} \nVolume:{controle.ConsultarVolume()}");

            Console.WriteLine("\nDiminuindo o canal");
            controle.DiminuirCanal();
            Console.WriteLine($"\nDados da TV:\nCanal:{controle.ConsultarCanal()} \nVolume:{controle.ConsultarVolume()}");

            Console.WriteLine("\nTrocar para o canal 3");
            controle.TrocarParaCanalIndicado(3);
            Console.WriteLine($"\nDados da TV:\nCanal:{controle.ConsultarCanal()} \nVolume:{controle.ConsultarVolume()}");

            Console.ReadKey();
        }
    }
}
