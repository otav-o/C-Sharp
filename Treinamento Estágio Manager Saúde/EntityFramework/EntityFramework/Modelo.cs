using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFramework
{
    public class Modelo
    {
        [Key()] // sinaliza para o gerador da base de dados que o Id é PK
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
