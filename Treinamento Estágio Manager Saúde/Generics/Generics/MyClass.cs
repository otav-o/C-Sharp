using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MyClass<T> where T: class, IEnemy<int>
    {
        public T valor;

        public MyClass(T valor, int inteiro)
        {
            valor.Damage(inteiro);
        }

        private T[] CreateArray(T first, T second)
        {
            return new T[2] { first, second };
        }


        // Quando a classe assina a interface, ela deve implementar seus métodos e propriedades, mas quando T assina, a classe não precisa. O tipo é que implementa, e esse código daria erro com o int, pois int não herda de IEnemy
    }
}
