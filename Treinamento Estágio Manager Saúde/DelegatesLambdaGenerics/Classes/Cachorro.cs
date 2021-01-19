using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Cachorro : ISerVivo
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public string Raca { get; set; }
        public string Cidade { get; set; }
        public Pessoa Dono { get; set; }

    }
}
