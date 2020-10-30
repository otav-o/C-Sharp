/*5. Faça um programa que leia um vetor de dimensão 5 e uma matriz quadrada de dimensão 5. Crie um procedimento que multiplique o vetor pela matriz. Imprima o resultado.*/

using System;

class Ex05 {
    
    static void Main() {
        int [] array = new int [5];
        int [,] matriz = new int [5,5];

    }

    static void leVetorEMatriz(int[] vet, int[,] m) {
        for (int i = 0; i < vet.Length; i++) {
            Console.Write("Pos.{0}: ", i);
            vet[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < m.GetLength(0); i++) {
            for (int j = 0; j < m.GetLength(1); j++) {
                Console.Write("({0},{1}): ", i, j);
                m[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    static void multVetEMatriz(int[] vet, int[,] m) {
        
    }

}