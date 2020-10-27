/*6) Crie um procedimento que receba uma frase e a exiba na tela de forma soletrada, ou seja, cada letra deve ser exibida na tela separada por hífen. [Ainda não estou fazendo POO]*/

using System;

class Ex06 {
    static void soletrar(string s) {
        for (int i = 0; i < s.Length; i++) {
            Console.Write("{0} - ", s[i]);
        }
    }

    static void Main() {
        Console.Write("Digite uma frase: ");
        soletrar(Console.ReadLine());
        
    }
} // feito, apesar de estar sobrando hífen no final e também aplicar a espaços.
