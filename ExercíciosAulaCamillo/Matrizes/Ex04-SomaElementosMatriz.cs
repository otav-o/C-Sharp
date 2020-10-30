/*4. Crie uma função que receba uma matriz de números reais e retorne a soma dos elementos desta matriz.*/

using System;

class Ex04 {
    static double somaElementosMat(double[,] m) {
        double soma = 0;
        for (int i = 0; i < m.GetLength(0); i++) {
            for (int j = 0; j < m.GetLength(1); j++) {
                soma += m[i,j];
            }
        }
        return soma;
    }
    
}