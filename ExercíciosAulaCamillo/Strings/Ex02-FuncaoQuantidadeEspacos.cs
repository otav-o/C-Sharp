/*2- Refaça o programa anterior criando uma função que receberá como parâmetro a string e retornará o número de espaços em branco que a string contém.*/
using System;

class Ex02 {
    static int numeroEspacos(string s) {
        int soma = 0;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == ' ') soma += 1;

        }
        return soma;
    }   

    static void Main() {
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine();
        Console.WriteLine("Esse texto tem {0} espaços.", numeroEspacos(texto));
    }
} // feito