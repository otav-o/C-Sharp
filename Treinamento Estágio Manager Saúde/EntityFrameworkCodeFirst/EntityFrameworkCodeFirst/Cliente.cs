using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCodeFirst
{
    public class Cliente
    {
        public int Id { get; set; } // o Entity é inteligente e já define como Id e auto-increment
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
