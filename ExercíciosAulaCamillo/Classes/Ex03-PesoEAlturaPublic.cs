/*3) Considerando a classe do exercício (2) e a inicialização abaixo:
joao.altura  1.90; joao.peso  98;
maria.altura  1.50; maria.peso  55;

- Escreva uma instrução que atribua 1.78 à altura de joao;
- Escreva uma instrução que atribua 75 ao peso de maria.
- Escreva um conjunto de instruções para imprimir a média
das alturas e a média dos pesos de joao e maria.*/

// vou refazer o programa deixando os atributos públicos

using System;

class Pessoa {
    public double altura, peso;

    public static double mediaAltura(params Pessoa[] p) { // inserir número variável de parâmetros
        double somaAltura = 0;
        for (int i = 0; i < p.Length; i++) {
            somaAltura += p[i].altura;
        }
        return somaAltura/p.Length;
    }

    public static double mediaPeso(params Pessoa[] p) {
        double somaPeso = 0;
        foreach (Pessoa x in p) {
            somaPeso += x.peso;
        }
        return somaPeso/p.Length;
    }
}

class Ex03 {
    static void Main() {
        Pessoa joao = new Pessoa();
        Pessoa maria = new Pessoa();

        joao.altura = 1.9; joao.peso = 98;
        maria.altura = 1.5; maria.peso = 55;

        Console.WriteLine("Média de pesos: {0}\nMédia de altura: {1}", Pessoa.mediaPeso(maria, joao), Pessoa.mediaAltura(maria, joao));

    } // coloquei métodos estáticos em uma classe não estática
} // feito