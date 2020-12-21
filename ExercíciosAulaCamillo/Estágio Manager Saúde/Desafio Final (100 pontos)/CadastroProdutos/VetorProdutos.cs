using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProdutos
{
    class VetorProdutos
    {
        private const int V = 100;
        public Produto[] Produtos { get; private set; } = new Produto[V];
        public double MediaPrecos { get; private set; }
        public int QuantidadeCadastrada { get; set; } = 0;

        /// <summary>
        /// Recebe do usuário informações para criar um produto e adicionar ao vetor.
        /// </summary>
        public void CadastrarProduto()
        {
            if (this.QuantidadeCadastrada == 100)
            {
                Console.WriteLine("Não é possível inserir mais produtos. Limite de 100 atingido");
                return;
                // TODO substituir por uma exceção
            }

            Console.Write("Código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Custo: ");
            double custo = Convert.ToDouble(Console.ReadLine());

            // O produto é inserido no próximo índice nulo
            this.Produtos[this.QuantidadeCadastrada] = new Produto(codigo, descricao, preco, custo);

            // QuantidadeCadastrada pertence ao vetor de produtos
            this.QuantidadeCadastrada++;
        }

        



    }
}
