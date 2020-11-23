using System;

namespace SistemaBancario
{
    class Cliente {
        public string nome, cpf, rg, endereco;
        public int idade;

        public bool EhMaiorDeIdade() {
            if (this.idade >= 18) return true;
            else return false;
        }
    }
}