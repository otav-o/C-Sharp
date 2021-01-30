using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EntityFrameworkCodeFirst
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; } // "Quero uma tabela do tipo Cliente chamada Clientes" -> automaticamente cria uma tabela no bd se ela não existir
    }
}
