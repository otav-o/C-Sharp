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
        
        public void Latir()
        {
            Console.WriteLine($"{this.Nome} diz: \"au-au\".");
        }

        public Action<Cachorro> Lamber = (Cachorro c) =>
        {
            Console.WriteLine($"{c.Nome} lambeu o sofá.");
        };

        public void FazerAlgo(this Cachorro c, Action procedimento)
        {
            
        }
    }
}
