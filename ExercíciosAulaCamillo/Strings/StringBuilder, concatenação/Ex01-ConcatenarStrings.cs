/*Faça um programa que leia duas strings e crie uam terceira que será a concatenação das duas lidas. */

using System;
using System.Text;

class Ex01 {
    static void Main() {
        Console.Write("Digite uma string: ");
        string s1 = Console.ReadLine();
        Console.Write("Digite outra: ");
        string s2 = Console.ReadLine();

        string s3 = s1 + s2;
        Console.WriteLine(s3 + " (feita com operador soma)");

        StringBuilder oi = new StringBuilder();
        oi.Append(s1); oi.Append(s2);
        Console.WriteLine("{0} (feita com StringBuilder)", oi.ToString());
    }
} // feito. Acabei de perceber que já fiz esse exercício kkk