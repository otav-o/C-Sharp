using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class EnemyMinion : IEnemy<int>
    {
        public EnemyMinion()
        {

        }
        public void Damage(int a)
        {
            Console.WriteLine("Procedimento Damage() de EnemyMinion, que herda de IEnemy" + a);
        }
    }
}
