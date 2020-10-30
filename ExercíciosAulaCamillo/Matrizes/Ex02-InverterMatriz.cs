/*4) Faça um programa que leia uma matriz quadrada de tamanho 10 e um procedimento que inverta as linhas pelas colunas em uma segunda matriz de mesmo tamanho. Imprima ao final a segunda matriz. Não tenha LER!!*/
using System;

class Ex02
{
    static void populaMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write("({0},{1}): ", i, j);
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    static int[,] inverteMatriz(int[,] matriz)
    {
        int[,] matInvertida = new int[matriz.GetLength(0), matriz.GetLength(1)];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matInvertida[i, j] = matriz[j, i];
            }
        }
        return matInvertida;
    }

    static void imprimeMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write("{0,3}", matriz[i, j]);
            }
            Console.Write("\n");
        }
    }

    static void Main()
    {
        int[,] oi = new int[10, 10]; // reduzir o valor para testar (óbvio)
        populaMatriz (oi);
        imprimeMatriz (oi);

        Console.WriteLine("=-=-=-=-=-=-");

        imprimeMatriz(inverteMatriz(oi));
    }
} // feito
