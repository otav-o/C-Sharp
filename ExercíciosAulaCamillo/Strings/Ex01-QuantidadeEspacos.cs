/*Fazer um programa para contar o número de espaços em branco de uma string*/
using System;

class Ex01
{
    static void Main()
    {
        Console.Write("Digite um texto com espaços: ");

        int qtd = 0;

        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ') qtd++; // espaço não é " " !!!
        }

        Console.WriteLine("Encontrei {0} espaços em branco!", qtd);
    }
} // feito
