/*QUESTÃO 02 (1 ponto): Faça uma função que receba por parâmetro uma matriz quadrada de strings e retorne a quantidade total de caracteres considerando todas as strings armazenadas na matriz. USAR CLASSES*/

using System;

class Questao2 {

    static int quantidadeChar(string [,] mat) {
        string soma = null;
        for (int i = 0; i < mat.GetLength(0); i++) {
            for (int j = 0; j < mat.GetLength(1); j++) {
                soma += mat[i, j];
            }
        }
        return soma.Length;
    }
    static void Main() {
        string [,] matriz = new string[3, 3] {{"oi", "ola", "oi"}, {"oi", "ola", "oi"}, {"oi", "ola", "oi"}};

        Console.WriteLine(quantidadeChar(matriz));

    }
} // feito