using System;

namespace CadastroProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            VetorProdutos VetProd = new VetorProdutos();
            Console.Write("-=-=-=-=-=-=-=" +
                "\nBem-vindo ao gerenciador de produtos" +
                "\n[a] Cadastrar produto" +
                "\n[b] Atualizar preço de um produto" +
                "\n[c] Imprimir preço médio dos produtos" +
                "\n[d] Mostrar todos os produtos" +
                "\nDigite a letra da opção desejada: ");

            char resp = Convert.ToChar(Console.ReadLine().ToLower().Trim());
            // TODO implementar exceção
            executarResposta(resp);



            


        }

        private static void executarResposta(char resp)
        {
            if (resp == 'a') CadastrarProduto();
        }

        private static void CadastrarProduto()
        {
            
        }
    }
}
