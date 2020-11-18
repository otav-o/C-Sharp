/*QUESTÃO 01 (1 ponto): Faça um programa que leia a descrição e o preço de cinquenta produtos. O programa deve imprimir a descrição e o preço do(s) produto(s) lido(s) que tiverem preço acima da média.*/

using System;

class Produto {
    public string desc;
    private double prec;


    public double preco {
        set {
            if (value > 0) prec = value;
            else prec = 0;
        }

        get {
            return prec;
        }
    }

    public static double CalculaMediaPrecos(Produto [] vet) {
        double soma = 0;
        for (int i = 0; i < vet.Length; i++) {
            soma += vet[i].preco;
        }
        return soma/vet.Length;
    }
}


class Questao1 {
    
    static Produto[] criarProdutos(int n) {
        Produto [] array = new Produto[n];
        for (int i = 0; i < n; i++) {
            array[i] = new Produto();
        }
        inserirProdutos(array);
        return array;
    }

    static void inserirProdutos(Produto [] vet) {
        for (int i = 0; i < vet.Length; i++) {
            Console.WriteLine("-- Produto {0}/{1} --", i + 1, vet.Length);
            Console.Write("Descrição: ");
            vet[i].desc = Console.ReadLine();

            Console.Write("Preço: R$");
            vet[i].preco = Convert.ToDouble(Console.ReadLine());
        }
    }

    static void imprimirProdutos(Produto [] vet, double media) {
        Console.WriteLine("Produtos cujo preço está acima da média: ");
        for (int i = 0; i < vet.Length; i++) {
            if (vet[i].preco > media)
                Console.WriteLine("{0,-15} R${1}", vet[i].desc, vet[i].preco);
        }
    }

    static void Main() {
        Produto [] array = criarProdutos(50);
        double media = Produto.CalculaMediaPrecos(array);
        imprimirProdutos(array, media); 
    }
} // feito