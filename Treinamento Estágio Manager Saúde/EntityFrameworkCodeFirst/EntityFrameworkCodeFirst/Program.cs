using System;
using System.Linq;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ClienteContext())
            {
                var quantidadeClientes = context.Clientes.Count();
                context.Clientes.Add(new Cliente() { Nome = "Danilo", Telefone = "8888891289" });
                context.SaveChanges(); // pega o objeto e insere
            }
            Console.WriteLine("Fim do programa");
        }
    }
}
