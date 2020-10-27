/*Faça um procedimento que faça a leitura um vetor de 10 elementos inteiros e imprima somente os valores armazenados nos >> índices << pares.*/

using System;

class Ex10 {
    static void somentePares() {
        int [] vet = new int[10];

        Console.WriteLine("Digite 10 números, um por linha:");

        for (int i = 0; i < 10; i++) {
            vet [i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Os valores armazenados em índices pares são: ");

        for (int i = 0; i < 10; i + 2) { // pq não vai??
            Console.Write(vet[i] + ' ');
        }
    }
    static void Main() {
        somentePares();
    }
} // erro linha 17