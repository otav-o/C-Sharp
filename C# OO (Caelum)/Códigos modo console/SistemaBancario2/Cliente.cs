using System;

namespace SistemaBancario2
{
    class Cliente {
        private string nome, cpf, rg, endereco;
        private int idade;


        public Cliente(string nome) { // construtor
            this.Nome = nome;   // usa-se propriedade Nome pois há auto-implemented properties
        }

        public Cliente (string nome, int idade) {
            this.Nome = nome;
            this.Idade = idade;
        }

        public string Nome {get; private set;}
        public string Cpf {get; set;} 
        public string Endereco {get; set;}
        public string Rg {get; set;}
        public int Idade {get; set;}

        public bool EhMaiorDeIdade() {
            if (this.idade >= 18) return true;
            else return false;
        }
    }
}