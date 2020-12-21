using System;

namespace CadastroProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            direcionaResposta(executarMenu());
        }

        /// <summary>
        /// Menu principal que exibe opções ao usuário e devolve sua resposta.
        /// </summary>
        private static char executarMenu()
        {
            Console.Write("-=-=-=-=-=-=-=" +
                "\nBem-vindo ao gerenciador de produtos" +
                "\n[a] Cadastrar produto" +
                "\n[b] Atualizar preço" +
                "\n[c] Imprimir preço médio" +
                "\n[d] Mostrar todos os produtos" +
                "\n[x] Encerrar programa" +
                "\nDigite a letra da opção desejada: ");

            char resp = Convert.ToChar(Console.ReadLine().ToLower().Trim());
            return resp;
            // TODO implementar exceção
        }

        private static void direcionaResposta(char resp)
        {
            if (resp == 'a') VetorProdutos.CadastrarProduto();
            if (resp == 'b') VetorProdutos.AtualizarPreco();
            if (resp == 'c') VetorProdutos.ImprimirPrecoMedio();
            if (resp == 'd') VetorProdutos.MostrarProdutos();
            if (resp == 'x') Finalizar();
            
        }

        private static void Finalizar()
        {
            throw new NotImplementedException();
        }

        private static void CadastrarProduto()
        {
            
        }


    }
}
