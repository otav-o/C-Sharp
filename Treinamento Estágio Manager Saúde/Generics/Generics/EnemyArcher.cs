using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class EnemyArcher : IEnemy
    {
        public void Damage()
        {
            Console.WriteLine("Damage() da classe EnemyArcher, que implementa IEnemy");
        }
    }
}
