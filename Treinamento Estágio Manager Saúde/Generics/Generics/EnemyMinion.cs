using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class EnemyMinion : IEnemy
    {
        public void Damage()
        {
            Console.WriteLine("Procedimento Damage() de EnemyMinion, que herda de IEnemy");
        }
    }
}
