namespace POO_Exercicio04
{
    public class ControleRemoto
    {
        private Televisao Televisao { get; set; }

        public ControleRemoto(Televisao televisao)
        {
            Televisao = televisao;
        }

        public void AumentarVolume() => Televisao.Volume++;

        public void DiminuirVolume()
        {
            if (Televisao.Volume >= 0)
                Televisao.Volume--;
        }

        public void AumentarCanal() => Televisao.Canal++;

        public void DiminuirCanal()
        {
            if (Televisao.Canal >= 0)
                Televisao.Canal--;
        }

        public void TrocarParaCanalIndicado(int canal) => Televisao.Canal = canal;

        public int ConsultarCanal() => Televisao.Canal;

        public int ConsultarVolume() => Televisao.Volume;
    }
}
