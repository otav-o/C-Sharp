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
            Console.WriteLine("Tipo: " + intArray.GetType() + "\nTamanho: " + intArray.Length + "\nPosição 1: " + intArray[0] + "\nPosição 2: " + intArray[1]);

        }

        private static int[] CreateArray(int firstElement, int secondElement)
        {
            return new int[] { firstElement, secondElement };
        }
    }
}
