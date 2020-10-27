/*7. Faça um algoritmo que leia, via teclado, 20 valores do tipo inteiro e determine qual o menor valor existente no vetor e imprima esse valor e seu índice no vetor.*/

using System;

class MetodosVetores {
    public int menor, maior = 0;
    private int [] vet;
    public MetodosVetores(int[] vet) {
        this.vet = vet;
        menorValor(vet); maiorValor(vet);
    }
    private int menorValor(int[] vet) {
        Array.Sort(vet);
        menor = vet[0];
        return menor;
    }
    private int maiorValor(int[] vet) {
        maior = menor = vet[0];
        for (int i = 1; i < vet.Length; i++) {
            if (vet[i] > maior) maior = vet[i];
            if (vet[i] < menor) menor = vet[i];
        }
        return maior;
    }
}
class Ex07 {
    static void Main() {

        
        int[] array = new int[10];

        Console.WriteLine("Digite 10 inteiros:");

        int num = 0;
        
        while (num < 10) {
            Console.Write("Número {0}: ", num+1);
            
            array[num] = Convert.ToInt32(Console.ReadLine());

            num++;
        }
        MetodosVetores teste = new MetodosVetores(array);
        
        Console.WriteLine("O menor valor digitado foi: {0}", teste.menor);
        Console.WriteLine("O maior valor digitado foi: " + teste.maior);
    }
} // feito
