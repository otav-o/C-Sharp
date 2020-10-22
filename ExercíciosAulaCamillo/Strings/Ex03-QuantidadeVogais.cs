/*3) Fazer um programa para contar o número de vogais em uma string.*/
using System;

class Ex03 {
    static void Main() {

        Console.Write("Digite uma string: ");

        string texto = Console.ReadLine().ToLower();

        int soma = 0;

        for (int i = 0; i < texto.Length; i++) {
            
            switch (texto[i]) {
                case 'a': soma++; break;
                case 'e': soma++; break;
                case 'i': soma++; break;
                case 'o': soma++; break;
                case 'u': soma++; break; // não precisava ter colocado um por linha kkk burro
                default: break;
            }
        }
        Console.WriteLine("Esse texto possui {0} vogais!", soma);
    }
} // feito. Mas não aceita minúsculas


