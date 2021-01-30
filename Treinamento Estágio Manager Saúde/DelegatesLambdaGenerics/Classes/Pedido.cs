using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Pedido <T>
    {
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }
        public T Objeto { get; set; }

        

    }
}
