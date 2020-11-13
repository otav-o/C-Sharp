// aula 11/11/2020

using System;
namespace Classes {
    class Atleta {

        public string Nome { // encapsulamento
            get { return nome; }
            set { nome = value; }
        }

        public double Peso {
            get { return peso; }
            set { peso = value }
        }

        public double Altura {
            get { return altura; }
            set { altura = value; }
        }

        /*public double GetImc() {
            return peso / Math.Pow(altura, 2);

        }*/

        public double Imc {
            get { return peso / altura * altura; }
        }
        private string nome;
        private double peso;
        private double altura;


    }
}