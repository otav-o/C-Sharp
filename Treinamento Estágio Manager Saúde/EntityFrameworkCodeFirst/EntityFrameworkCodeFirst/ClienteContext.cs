using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCodeFirst
{
    // Contexto do banco de dados. Aqui estão as tabelas
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; } // Tabela do tipo Cliente chamada "Clientes". As propriedades da classe Cliente serão as colunas

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Trusted_Connection=true;Persist Security Info=False;Initial Catalog=EntityCodeFirst;Data Source=localhost\SQLEXPRESS");
        }
    }
}
