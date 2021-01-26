using POO_Exercicio03;
using System;
using Xunit;

namespace TestesUnitarios
{
    public class Teste_POO_Exercicio03
    {
        [Fact]
        public void Saque_EmContaCorrente_AlteraSaldo()
        {
            double valorSaque = 300;
            double valorSaldo = 500;
            double valorTaxa = 0;
            double valorEsperado = valorSaldo - valorSaque;
            var _contaCorrente = new ContaCorrente("0001", valorSaldo, valorTaxa);

            _contaCorrente.Sacar(valorSaque);

            Assert.Equal(_contaCorrente.Saldo, valorEsperado);
        }

        [Fact]
        public void Saque_EmContaCorrenteComTaxa_DescontaTaxa()
        {
            double valorSaque = 300;
            double valorSaldo = 500;
            double valorTaxa = 10;
            double valorEsperado = valorSaldo - (valorSaque + valorTaxa);
            var _contaCorrente = new ContaCorrente("0001", valorSaldo, valorTaxa);

            _contaCorrente.Sacar(valorSaque);

            Assert.Equal(_contaCorrente.Saldo, valorEsperado);
        }

        [Fact]
        public void Saque_ComValorMaiorSaldoEmContaCorrente_LancaException()
        {
            double valorSaque = 900;
            double valorSaldo = 500;
            double valorTaxa = 0;
            var _contaCorrente = new ContaCorrente("0001", valorSaldo, valorTaxa);     

            Assert.Throws<InvalidOperationException>(() => _contaCorrente.Sacar(valorSaque));
        }

        [Fact]
        public void Saque_EmContaEspecial_AlteraSaldo()
        {
            double valorSaque = 300;
            double valorSaldo = 500;
            double valorLimite = 0;
            double valorEsperado = valorSaldo - valorSaque;
            var _contaEspecial = new ContaEspecial("0001", valorSaldo, valorLimite);

            _contaEspecial.Sacar(valorSaque);

            Assert.Equal(_contaEspecial.Saldo, valorEsperado);
        }

        [Fact]
        public void Saque_EmContaEspecial_UtilizaLimite()
        {
            double valorSaque = 700;
            double valorSaldo = 500;
            double valorLimite = 1000;
            double valorEsperado = valorSaldo - valorSaque;
            var _contaEspecial = new ContaEspecial("0001", valorSaldo, valorLimite);

            _contaEspecial.Sacar(valorSaque);

            Assert.Equal(_contaEspecial.Saldo, valorEsperado);
        }

        [Fact]
        public void Saque_ComValorMaiorQueLimiteEmContaEspecial_LancaException()
        {
            double valorSaque = 2000;
            double valorSaldo = 500;
            double valorLimite = 1000;
            var _contaEspecial = new ContaEspecial("0001", valorSaldo, valorLimite);

            Assert.Throws<InvalidOperationException>(() => _contaEspecial.Sacar(valorSaque));
        }

        [Fact]
        public void Deposito_EmContaCorrente_AlteraSaldo()
        {
            double valorDeposito = 300;
            double valorSaldo = 0;
            double valorTaxa = 0;
            double valorEsperado = valorSaldo + valorDeposito;
            var _contaCorrente = new ContaCorrente("0001", valorSaldo, valorTaxa);

            _contaCorrente.Depositar(valorDeposito);

            Assert.Equal(_contaCorrente.Saldo, valorEsperado);
        }

        [Fact]
        public void Deposito_EmContaCorrente_DescontaTaxa()
        {
            double valorDeposito = 300;
            double valorSaldo = 0;
            double valorTaxa = 10;
            double valorEsperado = valorSaldo +(valorDeposito - valorTaxa);
            var _contaCorrente = new ContaCorrente("0001", valorSaldo, valorTaxa);

            _contaCorrente.Depositar(valorDeposito);

            Assert.Equal(_contaCorrente.Saldo, valorEsperado);
        }

        [Fact]
        public void Deposito_EmContaEspecial_AlteraSaldo()
        {
            double valorDeposito = 300;
            double valorSaldo = 0;
            double valorLimite = 1000;
            double valorEsperado = valorSaldo + valorDeposito;
            var _contaEspecial = new ContaEspecial("0001", valorSaldo, valorLimite);

            _contaEspecial.Depositar(valorDeposito);

            Assert.Equal(_contaEspecial.Saldo, valorEsperado);
        }
    }
}
