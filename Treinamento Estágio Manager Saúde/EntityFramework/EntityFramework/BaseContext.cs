using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("Relacionamento") { } // essa é a base de dados
        public DbSet<Modelo> Modelos { get; set; } // essas 2 são as coleções
        public DbSet<Carro> Carros { get; set; }
    }
}
