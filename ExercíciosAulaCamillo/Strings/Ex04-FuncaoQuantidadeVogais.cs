/*4) Refaça o programa anterior criando uma função que receberá como parâmetro a string e retornará o número de vogais que a string contem. [ainda não estou usando POO]*/

using System;
class Ex04 {
    static int numeroVogais(string s) {
        int qtd = 0;
        for (int i = 0; i < s.Length; i++) {
            switch(s[i]) {
                case 'A': 
                case 'E': 
                case 'I': 
                case 'O': 
                case 'U': 
                case 'a': 
                case 'e': 
                case 'i': 
                case 'o': 
                case 'u': qtd++; break;
                default: break;
            }
        }
        return qtd;
    }
    static void Main() {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Este texto possui {0} vogais.", numeroVogais(input));
    }
} // feito e funciona com maiúsculas (o prof não deixa usar funções de string)