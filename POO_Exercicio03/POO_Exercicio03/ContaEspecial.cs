using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Exercicio03
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {
        public double Limite { get; set; }

        public ContaEspecial(string numero, double saldo, double limite) : base(numero, saldo)
        {
            Limite = limite;
        }

        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            if (valor > (Saldo + Limite))
            {
                throw new InvalidOperationException("Valor do saque é maior que o saldo + limite disponível na conta");
            }

            Saldo -= valor;
        }

        public string MostrarDados()
        {
            return $"Conta Especial. \nNúmero da conta: {NumeroDaConta} \nSaldo: {Saldo} R$ \nLimite: {Limite}";
        }

    }
}
