/*Faça um programa para exibir a soma de duas matrizes quadradas 3x3. Deverá ser criado um procedimento para ler um matriz (será chamado duas vezes com parâmetros diferentes) e um segundo procedimento que irá imprimir a soma das matrizes passadas como parâmetro*/
using System;

class Ex01
{
    static void somaMatriz(int[,] mat1, int[,] mat2)
    {
        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.GetLength(1); j++)
            {
                Console.Write("{0,5}", mat1[i, j] + mat2[i, j]);
            }

        Console.WriteLine("");

        }
        
    }

    static void leMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write("({0}, {1}): ", i, j);

                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        } // não tem que retornar pois é o mesmo endereço de memória; a variável não armazena o objeto, e sim a referência dele
    }

    static void Main()
    {
        int[,] m1 = new int[3, 3];
        int[,] m2 = new int[3, 3];
        Console.WriteLine("Primeira matriz: ");
        leMatriz (m1);
        Console.WriteLine("Segunda matriz: ");
        leMatriz (m2);

        somaMatriz(m1, m2);
    }
} // feito. Novidade: matriz.GetLength(n)
