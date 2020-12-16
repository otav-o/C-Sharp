using System;
using System.Collections.Generic;
using System.Text;

namespace Eleicao
{
    class Eleicao
    {
        /// <summary>
        /// Quantidade de candidatos que podem se cadastrar
        /// </summary>
        public int QtdCandidatos { get; set; }

        /// <summary>
        /// Quantidade de votos que serão disponibilizados
        /// </summary>
        public int QtdEleitores { get; set; }

        /// <summary>
        /// Registra os candidatos à eleição
        /// </summary>
        public Candidato[] Candidatos { get; set; }

        /// <summary>
        /// Cria uma eleição
        /// </summary>
        /// <param name="qtdCandidatos">Número de candidatos ao cargo</param>
        /// <param name="qtdEleitores">Número de pessoas que vão votar</param>
        public Eleicao(int qtdCandidatos, int qtdEleitores)
        {
            QtdCandidatos = qtdCandidatos;
            QtdEleitores = qtdEleitores;

            Candidatos = new Candidato[QtdCandidatos];
        }
        /// <summary>
        /// Cria e adiciona um candidato à eleição.
        /// </summary>
        /// <param name="nome">Nome do candidato</param>
        /// <param name="numero">Número do partido</param>
        /// <param name="indice">Posição do array</param>
        public void AdicionarCandidato(string nome, int numero, int indice)
        {
            Candidatos[indice] = new Candidato(nome, numero);
        }

        /// <summary>
        /// Pede ao usuário os dados do candidato para fins de cadastro.
        /// </summary>
        public void LeCandidatos()
        {
            int max = this.Candidatos.Length;
            string nome;
            int numero;
            for (int i = 0; i < max; i++)
            {
                Console.Write("Nome do candidato [{0}/{1}]: ", i + 1, max);
                nome = Console.ReadLine();

                Console.Write("Número do {0}: ", Candidatos[i].Nome);
                numero = Convert.ToInt32(Console.ReadLine());

                AdicionarCandidato(nome, numero, i);

            }
        }

        public void PreencheVotos(Candidato c)
        {
            
        }

        public Candidato[] RankingVencedores()
        {

        }

        public void ImprimeRanking()
        {

        }

    }
}
