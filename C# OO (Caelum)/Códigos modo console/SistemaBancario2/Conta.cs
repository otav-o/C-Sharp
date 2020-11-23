using System;

namespace SistemaBancario2 {
    
    class Conta { 

        private Cliente titular;
        private int numero;
        private double saldo;

        public Cliente Titular { 
            get {return titular;} 
            set {titular = value;} 
        }

        public int Numero { 
            get {return numero;} 
            set {numero = value;} 
        }

        public double Saldo { 
            get {return saldo;} 
        }

        public void Deposita(double valor) {
            this.saldo += valor;
        }

        public bool Saca(double valor) {
            if (this.saldo >= valor && this.Titular.Idade >= 18) {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transfere(Conta destino, double valor) {
            if (this.Saca(valor)) {
                destino.Deposita(valor);
                return true;
            }
            return false;
        }

        public void ImprimeDados() {
            Console.WriteLine("---");
            Console.WriteLine("Titular: " + this.titular);
            Console.WriteLine("Numero: " + this.numero);
            Console.WriteLine("Saldo: " + this.saldo);

        }
    }

}