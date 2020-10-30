/*3. Faça um procedimento que receba uma matriz quadrada 5 x 5 e crie uma matriz identidade. Imprima a matriz após sua inicialização em um outro procedimento.
"A matriz M é chamada de Matriz Identidade de ordem n (indicada por In) quando os elementos da diagonal principal são todos iguais a 1 e os elementos restantes são iguais a zero."*/

using System;

class Ex03 {
    static void matrizIdentidade(double[,] m) {
        for (int i = 0; i < m.GetLength(0); i++) {
            for (int j = 0; j < m.GetLength(1); j++) {
                if (i == j) m[i,j] = 1;
                else m[i,j] = 0;
            }
        }

    }
    static void imprimeMatriz(double[,] m) {
        for (int i = 0; i < m.GetLength(0); i++) {
            for (int j = 0; j < m.GetLength(1); j++) {
                Console.Write ("{0,3}", m[i,j]);
            }
            Console.Write("\n");
        }
        
    }
    static void Main() {
        double [,] mat = new double[5,5];
        matrizIdentidade(mat);
        imprimeMatriz(mat);

    }
} // feito