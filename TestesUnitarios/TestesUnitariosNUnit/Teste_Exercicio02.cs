using MestreDosCodigos_Exercicio02;
using NUnit.Framework;
using System;

namespace TestesUnitariosNUnit
{
    public class Teste_Exercicio02
    {
        [Test]
        public void CompareTo_ComObjetoInvalido_DeveLancarException()
        {
            var funcionario01 = new Funcionario("José", 1500);

            Assert.Throws<ArgumentException>(() => funcionario01.CompareTo(new { nome = "teste", salario = 1900 }));
        }

        [Test]
        public void CompareTo_ComMaiorSalario_DeveRetornarMenorQueZero()
        {
            var funcionario01 = new Funcionario("José", 1500);
            var funcionario02 = new Funcionario("Milton", 2000);

            var compare = funcionario01.CompareTo(funcionario02);

            Assert.Less(compare, 0);
        }

        [Test]
        public void CompareTo_ComMenorSalario_DeveRetornarMaiorQueZero()
        {
            var funcionario01 = new Funcionario("José", 2000);
            var funcionario02 = new Funcionario("Milton", 1500);

            var compare = funcionario01.CompareTo(funcionario02);

            Assert.Greater(compare, 0);
        }

        [Test]
        public void CompareTo_ComSalariosIguais_DeveRetornarZero()
        {
            var funcionario01 = new Funcionario("José", 2000);
            var funcionario02 = new Funcionario("Milton", 2000);

            var compare = funcionario01.CompareTo(funcionario02);

            Assert.AreEqual(compare, 0);
        }
    }
}