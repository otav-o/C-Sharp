using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProdutos
{
    class Produto
    {
        /// <summary>
        /// Cria um produto
        /// </summary>
        /// <param name="codigo">Identificador do produto.</param>
        /// <param name="descricao">Informações do produto.</param>
        /// <param name="preco">Preço de venda.</param>
        /// <param name="custo">Preço de custo.</param>
        public Produto(int codigo, string descricao, double preco, double custo)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Preco = preco;
            this.Custo = custo;
        }


        /// <summary>
        /// Número inteiro que identifica o produto.
        /// </summary>
        public int Codigo { get; private set; }

        /// <summary>
        /// Texto que armazena informações do produto.
        /// </summary>
        public string Descricao { get; private set; }

        /// <summary>
        /// Valor de venda do produto.
        /// </summary>
        public double Preco { get; private set; }

        /// <summary>
        /// Custo do produto para o lojista.
        /// </summary>
        public double Custo { get; private set; }

    }
}
