using MestreDosCodigos_Exercicio04;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestesUnitariosNUnit
{
    public class Teste_Exercicio04
    {
        [Test]
        public void CalcularMediaDasNotas_ComListaDeNotas_DeveRetornarMedia()
        {
            var mediaEsperada = 10;
            var notasAluno = new List<double>
            {
                10,10,10
            };

            var alunoTeste = new Aluno("José", notasAluno);

            var mediaAluno = alunoTeste.CalcularMediaDasNotas();

            Assert.AreEqual(mediaEsperada, mediaAluno);
        }
    }
}
