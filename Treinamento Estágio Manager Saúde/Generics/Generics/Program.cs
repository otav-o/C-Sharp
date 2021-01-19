using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            int[] intArray = CreateArray(5, 6);
            PrintArray<int>(intArray);
            PrintArray<string>(CreateArray("Oi", "Olá"));
            PrintArray(CreateArray<double>(5, 6));
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
