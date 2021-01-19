using System;

namespace POO_Exercicio03
{
    public class ContaCorrente : ContaBancaria, IImprimivel
    {
        public double TaxaDeOperacao { get; set; }

        public ContaCorrente(string numero, double saldo, double taxaDeOperacao) : base(numero, saldo)
        {
            TaxaDeOperacao = taxaDeOperacao;
        }

        public override void Depositar(double valor) => Saldo += valor - TaxaDeOperacao;

        public override void Sacar(double valor)
        {
            if(valor > Saldo)
            {
                throw new InvalidOperationException("Valor do saque é maior que o saldo disponível na conta");
            }

            Saldo -= (valor - TaxaDeOperacao);
        }

        public string MostrarDados()
        {
            return $"Conta Corrente. \nNúmero da conta: {NumeroDaConta} \nSaldo: {Saldo} R$ \nTaxa de operação: {TaxaDeOperacao}";
        }
    }
}
