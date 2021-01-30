using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFramework
{
    public class Carro
    {
        [Key()]
        public int Id { get; set; }
        public int ModeloId { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
    }
}
