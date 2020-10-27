/*Desenvolva um programa que leia um vetor de números reais, um escalar e imprima o resultado da multiplicação do vetor pelo escalar.*/
using System;
class Ex09 {

    static int[] lerVetor(int [] v) {
        for (int i = 0; i < v.Length; i++) {
            Console.Write("Digite o elemento {0}/{1}: ", i + 1, v.Length);
            v[i] = Convert.ToInt32(Console.ReadLine());
        }
        return v;
    }

    static void multiplicar(int[] vetor, int num) {
        for (int i = 0; i < vetor.Length; i++) {
            Console.WriteLine("{0} x {1} = {2}", vetor[i], num, vetor[i] * num);
        }
    }
    static void Main() {
        Console.Write("Quantos elementos terá o vetor? ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] vetor = new int[n];
        vetor = lerVetor(vetor);

        Console.Write("Insira um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        multiplicar(vetor, num);
    }
} // feito