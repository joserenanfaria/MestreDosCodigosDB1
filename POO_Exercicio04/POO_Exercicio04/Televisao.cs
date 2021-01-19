using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Exercicio04
{
    public class Televisao
    {
        public IReadOnlyDictionary<int, string> Canais { get; private set; }
        public int Volume { get; set; }
        public int CanalSelecionado { }


        public Televisao()
        {
            Canais = new Dictionary<int, string>
            {
                { 0, "Globo" },
                { 1, "SBT" },
                { 2, "Rede Vida" }
            };

            Volume = 0;
        }
    }
}
