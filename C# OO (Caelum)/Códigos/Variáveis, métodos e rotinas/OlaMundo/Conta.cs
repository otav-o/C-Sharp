using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo
{
    class Conta
    {

        public void Transfere (Conta destino, double valor)
        {
            if (this.saldo >= valor)
            {
                this.Saca(valor);
                destino.Deposita(valor);
            }
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Saca(double valor)
        {
            if (valor <= this.saldo)
                this.saldo -= valor;
        }

        private double saldo;
        private string titular;
        private int numero;

        public String Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
    }
}
