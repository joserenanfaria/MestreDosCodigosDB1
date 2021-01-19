using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Exercicio03
{
    public abstract class ContaBancaria
    {
        protected ContaBancaria(string numeroDaConta, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        public string NumeroDaConta { get; set; }
        public double Saldo { get; set; }

        public abstract void Sacar(double valor);

        public abstract void Depositar(double valor);
    }
}
