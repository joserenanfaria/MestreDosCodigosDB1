using POO_Exercicio04;
using Xunit;

namespace TestesUnitarios
{
    public class Teste_POO_Exercicio04
    {
        [Fact]
        public void AumentarVolume_AumentarValido_DeveAumentarUmaUnidade()
        {
            var controleRemoto = new ControleRemoto(new Televisao());
            int volumeEsperado = 1;

            controleRemoto.AumentarVolume();

            Assert.Equal(controleRemoto.ConsultarVolume(), volumeEsperado);
        }

        [Fact]
        public void AumentarCanal_AumentarValido_DeveTrocarCanal()
        {
            var controleRemoto = new ControleRemoto(new Televisao());
            int canalEsperado = 1;

            controleRemoto.AumentarCanal();

            Assert.Equal(controleRemoto.ConsultarCanal(), canalEsperado);
        }

        [Fact]
        public void TrocarCanal_TrocarParaCanalEspecifico_DeveTrocarParaCanalEspecifico()
        {
            var controleRemoto = new ControleRemoto(new Televisao());
            int canalEsperado = 7;

            controleRemoto.TrocarParaCanalIndicado(7);

            Assert.Equal(controleRemoto.ConsultarCanal(), canalEsperado);
        }
    }
}
