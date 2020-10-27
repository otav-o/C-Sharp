/*Faça uma função que recebe um vetor de números reais...*/

using System;

class Ex05 {
    static void AtualizaVetor(double [] vet) {
        for (int i = 0; i < vet.Length; i++) {
            if (vet[i] > 100 && vet[i] < 300) {
                vet[i] *= 1.15;
            } else if (vet[i] >= 300 && vet[i] < 500){
                vet[i] *= 1.25;
            } else {
                vet[i] *= 1.05;
            }
        }
    }

    static double[] CriaVetorDouble(int n) {
        double [] array = new double[n];
        for (int i = 0; i < n; i++) {
            Console.Write("Elemento [{0}/{1}]: ", i + 1, n);
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        return array;
    }

    static void ImprimeVetor(double [] vet) {
        for (int i = 0; i < vet.Length; i++) {
            Console.WriteLine(vet[i]);
        }
    }
    static void Main() {
        Console.Write("Vamos montar um vetor! Quantos elementos ele vai ter? ");
        int n = Convert.ToInt32(Console.ReadLine());

        double [] vetor = CriaVetorDouble(n);
        ImprimeVetor(vetor);
        AtualizaVetor(vetor);
        Console.WriteLine("-=-=-=-=-");
        ImprimeVetor(vetor);
    
    }
}