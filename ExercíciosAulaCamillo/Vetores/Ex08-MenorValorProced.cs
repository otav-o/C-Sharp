/*Refaça o exercício anterior criando um procedimento que receba como parâmetro o vetor e imprima o menor valor e seu índice no vetor.*/

using System;
class Ex08 {
    static int [] criarVetor(int tamanho) {
        int [] vetor = new int[tamanho];
        for (int i = 0; i < tamanho; i++) {
            Console.Write("Digite o valor {0}/{1}: ", i + 1, tamanho);
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
        return vetor;

    }
    static void menorValor(int [] vet) {
        int menorV = vet[0];
        int menorIndice = 0;
        for (int i = 0; i < vet.Length; i++) {
            if (vet[i] < menorV) {
                menorV = vet[i];
                menorIndice = i;
            }
        }
        Console.WriteLine("O menor valor é {0}, que está no índice {1}", menorV, menorIndice);
    }
    static void Main() {
        Console.Write("Quantos números vc quer digitar? ");
        menorValor(criarVetor(Convert.ToInt32(Console.ReadLine())));
        
        
    }
} // feito. Ficou legal