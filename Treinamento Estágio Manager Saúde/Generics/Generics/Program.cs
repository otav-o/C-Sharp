using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.WriteLine("---");
            TestMultiGenerics("olá", true);

            // MyClass<int> myClass = new MyClass<int>();
                // não funciona pois int não implementa a interface. T deve implementar IEnemy, pois usou-se o where

            MyClass<IEnemy> myClass = new MyClass<IEnemy>(new EnemyArcher());
            MyClass<EnemyArcher> myClass2 = new MyClass<EnemyArcher>(new EnemyArcher());

            // MyClass<EnemyMinion> myClass3 = new MyClass<EnemyMinion>(new EnemyArcher());
            // O tipo de MyClass<> deve ser o mesmo do parâmetro (ambos são T)

            Console.WriteLine(myClass.value); 
            Console.WriteLine(myClass2.value);
            myClass.value.Damage();
            myClass2.value.Damage();

        }

        private static void Start()
        {
            int[] intArray = CreateArray(5, 6);
            PrintArray<int>(intArray);
            PrintArray<string>(CreateArray("Oi", "Olá"));
            PrintArray(CreateArray<double>(5, 6));
        }

        private static void TestMultiGenerics<T1, T2>(T1 t1, T2 t2)
        {
            Console.WriteLine(t1.GetType());
            Console.WriteLine(t2.GetType());
        }

        private static T[] CreateArray<T>(T firstElement, T secondElement)
        {
            return new T[] { firstElement, secondElement };
        }

        private static void PrintArray<T>(T[] vetor)
        {
            Console.WriteLine("Tipo: " + vetor.GetType() + "\nTamanho: " + vetor.Length + "\nPosição 1: " + vetor[0] + "\nPosição 2: " + vetor[1]);
        }
    }
}
