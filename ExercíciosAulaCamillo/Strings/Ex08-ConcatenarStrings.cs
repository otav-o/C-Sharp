/*8) Faça um programa que leia duas strings e crie uma terceira string que será a concatenação das duas outras strings lidas.[Ainda não estou em POO]*/

using System;
class Ex08 {
    static string concatenar(string s1, string s2) {
        return s1 + ' ' + s2;
    }
    static void Main() {
        Console.Write("Digite um texto: ");
        string texto1 = Console.ReadLine();
        Console.Write("Digite outro texto: ");
        string texto2 = Console.ReadLine();

        Console.WriteLine(concatenar(texto1, texto2));
    }
} // feito