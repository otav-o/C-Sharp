/*QUESTÃO 01 (2 pontos): Faça uma função que receba por parâmetro uma matriz de números inteiros e retorne a média dos elementos pertencentes à última coluna da matriz.*/

using System;

class Questao1 {
    static double mediaUltimaColuna(int[,] mat) {
        int soma = 0;
        int ultimaColuna = mat.GetLength(1) - 1;
        for (int i = 0; i < mat.GetLength(0); i++) {
            soma += mat[i, ultimaColuna];
        }
        return soma/mat.GetLength(0); // quase errei. Ia enviar com GetLength(1)
    }

    static void Main() {
        int[,] matriz = new int[3,2] {{1, 2}, {1, 2}, {1, 2}};
        Console.WriteLine(mediaUltimaColuna(matriz));

        int [,] mat2 = new int[2,2] {{5, 1}, {2, 3}};
        Console.WriteLine(mediaUltimaColuna(mat2));
    }
} // feito.

