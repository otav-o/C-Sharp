/*5. Refaça o exercício anterior criando um procedimento para efetuar a leitura dos vetores e um segundo procedimento que imprimirá a soma dos vetores.*/

using System;

public static class OperacaoVetores {
    public static void somarVetores(int[] vet1, int[] vet2) {
        if (vet1.Length != vet2.Length) {
            Console.WriteLine("ERRO. Ambos os vetores precisam ter o mesmo tamanho");
            return; // na verdade fiz isso a toa; sem contar que na vida real eu usaria o set/get para controle
        }
        for (int i = 0; i < vet1.Length; i++) {
            Console.WriteLine("{0} + {1} = {2}", vet1[i], vet2[i], vet1[i] + vet2[i]);
        }
        
    }
    public static int[] montarVetorInt(int tamanho) {
        int[] array = new int[tamanho];
        for (int i = 0; i < tamanho; i++) {
            Console.Write("Insira o valor {0}/{1}: ", i + 1, tamanho);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }
}

class Ex05 {
    static void Main() {
        Console.Write("-=-=-=-=-=-=-=-=-=-\nOlá! Vamos somar 2 vetores. \nQuantos elementos eles terão? ");
        int n = Convert.ToInt32(Console.ReadLine());

        OperacaoVetores.somarVetores(OperacaoVetores.montarVetorInt(n), OperacaoVetores.montarVetorInt(n));
        
    }
} // feito
