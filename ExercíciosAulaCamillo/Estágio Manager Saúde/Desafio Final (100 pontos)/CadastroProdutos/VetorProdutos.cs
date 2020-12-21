using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProdutos
{
    /// <summary>
    /// Classe que armazena um vetor de produtos.
    /// </summary>
    static class VetorProdutos
    {

        private const int V = 100;

        public static Produto[] Produtos { get; private set; } = new Produto[V];
        public static int QuantidadeCadastrada { get; set; } = 0;

        /// <summary>
        /// Recebe do usuário informações para criar um produto e adicionar ao vetor.
        /// </summary>
        public static void CadastrarProduto()
        {
            if (QuantidadeCadastrada != 100)
            {
                Console.Write("Código: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Descrição: ");
                string descricao = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = Convert.ToDouble(Console.ReadLine());

                Console.Write("Custo: ");
                double custo = Convert.ToDouble(Console.ReadLine());

                // O produto é inserido no próximo índice nulo
                Produtos[QuantidadeCadastrada] = new Produto(codigo, descricao, preco, custo);

                // QuantidadeCadastrada pertence ao vetor de produtos
                QuantidadeCadastrada++;
            }
            else
            {
                Console.WriteLine("Não é possível inserir mais produtos. Limite de 100 atingido");
                return;
                // TODO substituir por uma exceção
            }
        }
        /// <summary>
        /// Imprime todos os produtos e suas propriedades
        /// </summary>
        internal static void MostrarProdutos()
        {
            for (int i = 0; i < QuantidadeCadastrada; i++) // o foreach percorre posições nulas e dá erro
            {
                Produto p = Produtos[i];
                Console.WriteLine("Cod.: {0}" +
                    "\n  Descrição: {1}" +
                    "\n  Preço: R${2:N2}" +
                    "\n  Custo: R${3:N2}",
                    p.Codigo, p.Descricao, p.Preco, p.Custo);
            }
        }

        /// <summary>
        /// Chama a função CalculaPrecoMedio() e imprime o resultado
        /// </summary>
        internal static void ImprimirPrecoMedio()
        {
            Console.WriteLine("O preço médio de {0} produtos cadastrados é R${1:N2}.", QuantidadeCadastrada, CalculaPrecoMedio());
        }

        /// <summary>
        /// Percorre o vetor Produtos, calcula e retorna o preço médio deles
        /// </summary>
        /// <returns></returns>
        private static double CalculaPrecoMedio()
        {
            double soma = 0;
            for (int i = 0; i < QuantidadeCadastrada; i++)
            {
                soma += Produtos[i].Preco;
            }
            return soma / QuantidadeCadastrada;
        }

        /// <summary>
        /// Lê as informações do usuário e chama Produto.AumentaPreco() e Produto.ReduzPreco()
        /// </summary>
        internal static void AtualizarPreco()
        {
            // Ler o código do produto
            Console.Write("** Atualização de preço\nDigite o código do produto: ");
            int cod = Convert.ToInt32(Console.ReadLine());

            // Receber o produto
            Produto p = BuscarProduto(cod);

            // TODO tratar exceção buscar produto

            Console.Write("Você deseja aumentar ou reduzir o preço? ");
            int respAouR = Convert.ToChar(Console.ReadLine().ToLower().Trim()[0]); // pega o primeiro caractere

            // TODO tratar exceção respAouR

            Console.Write("Em quantos por cento? ");
            double porcentagem = Convert.ToDouble(Console.ReadLine()) / 100;

            if (respAouR == 'a') p.AumentaPreco(porcentagem);
            else if (respAouR == 'r') p.ReduzPreco(porcentagem);

            Console.WriteLine("Sucesso. Novo preço: R${0:N2}", p.Preco);
        }

        /// <summary>
        /// Retorna um produto do vetor da classe. 
        /// </summary>
        /// <param name="cod">Código cadastrado para o produto.</param>
        /// <returns></returns>
        private static Produto BuscarProduto(int cod)
        {
            foreach (Produto p in Produtos)
            {
                if (p.Codigo == cod)
                    return p;
            }
            return null;
            // TODO lançar uma exceção
        }
    }
}
