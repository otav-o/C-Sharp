/*QUESTÃO 02 (1 ponto): Faça um procedimento que receba um vetor de números reais e imprima o menor e o maior número encontrado no vetor passado por parâmetro.*/

using System;

class Questao2 {

    static void maiorEMenorNumero(double [] vet) {
        double maior, menor;
        maior = menor = vet[0];
        for (int x = 1; x < vet.Length; x++) {
            if (vet[x] > maior) maior = vet[x];
            if (vet[x] < menor) menor = vet[x];
        }
        Console.WriteLine("Maior número: {0}\nMenor número: {1}", maior, menor);
    }

    static void leVetorDouble(double [] vet) {
        for (int i = 0; i < vet.Length; i++) {
            Console.Write("Valor {0} de {1}: ", i + 1, vet.Length);
            vet[i] = Convert.ToDouble(Console.ReadLine());
        }
    }
    static void Main() {
        Console.Write("Quantos números você deseja inserir? ");
        int n = Convert.ToInt32(Console.ReadLine());
        double [] numeros = new double[n];
        leVetorDouble(numeros);
        maiorEMenorNumero(numeros);

    }

}