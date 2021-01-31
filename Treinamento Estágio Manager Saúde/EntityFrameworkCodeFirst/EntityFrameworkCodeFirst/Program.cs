using System;
using System.Linq;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ClienteContext()) // lembrar que contexto é de todo o projeto, não somente de Cliente
            {
                var quantidadeClientes = context.Clientes.Count();
                context.Clientes.Add(new Cliente() { Nome = "Danilo", Telefone = "8888891289", Cpf = "1234556768" });

                context.Produtos.Add(new Produto() { Nome = "Câmera", Descricao = "Muito boa" });
                context.SaveChanges();

                var query = context.Clientes.Where(c => c.Nome.Contains("Danilo")).ToString();
                var clientes = context.Clientes.Where(c => c.Nome.Contains("Danilo")).ToList(); // retorna os modelos
            }
            Console.WriteLine("Fim do programa");
        }
    }
}
