using System;
using System.Collections.Generic;
using System.Text;

namespace Eleicao
{
    /// <summary>
    /// Representa um candidato que participa de uma eleição
    /// </summary>
    class Candidato
    {
        public string Nome { get; set; }
        /// <summary>
        /// Representa o número que o eleitor deve inserir para votar no candidato
        /// </summary>
        public int Numero { get; set; }
        public int QuantidadeVotosRecebidos { get; set; } // e se eu quiser que o candidato participe de várias eleições?


        public Candidato(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        }
    }
}
