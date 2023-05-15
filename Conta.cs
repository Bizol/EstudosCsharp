using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContaBancaria {
    internal class Conta {

        public string Nome { get; private set; }
        public int Numero { get; set; }
        public double Saldo { get; private set; }

        public Conta(string nome, int numero) {
            Nome = nome;
            Numero = numero;
        }
        public Conta(string nome, int numero, double depositoInicial) :this(nome, numero) {
            Deposito(depositoInicial);
        }
        public void Deposito(double valor) {
            Saldo += valor;
        }
        public void Saque(double valor) {
            Saldo -= valor + 5.00;
        }
        public override string ToString() {

            return "conta: " 
                + Numero 
                + ", Titular: " 
                + Nome 
                + ", Saldo: $" 
                + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }       
    }
}
