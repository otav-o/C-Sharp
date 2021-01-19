using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class EnemyArcher : IEnemy<int>
    {
        public EnemyArcher() { }
        public void Damage(int t)
        {
            Console.WriteLine("Damage() da classe EnemyArcher, que implementa IEnemy" + t);
        }
    }
}
