/*5) Escreva um programa para ler uma string (com mais de uma palavra) e imprimi-la de forma que a primeira letra de cada palavra fique em maiúscula. Para isso, basta subtrair 32 do elemento que deseja alterar para maiúsculo.

Console.Write("{0} ", Convert.ToChar(chrNomeRecebido[i] – 32));
                ou
Console.Write("{0} ", Convert.ToChar(chrNomeRecebido[i] – 'a' + 'A' ));*/

using System;
class Ex05 {
    /*static string Capitalizar(string s) {
        for (int i = 0; i < s.Length; i++) {
            if (s[i-1] == ' ' || i == 0) {
                s[i] -= 32;
            }
        }
        return s;
    }*/ // não consegui modificar a string
static void Main() {
    Console.Write("Insira um texto: ");
    string input = Console.ReadLine();
    for (int i = 0; i < input.Length; i++) {
        // if (input[i-1] == ' ' || i == 0) falou que tava fora do range
        if (i == 0)
            Console.Write(Convert.ToChar(input[i] - 'a' + 'A')); // sem o Convert.ToChar, fica numérico
        else if (input[i-1] == ' ')
            Console.Write(Convert.ToChar(input[i] - 'a' + 'A'));
        else
            Console.Write(input[i]);
    }
    

    /*input[0] = 'B';
    Console.WriteLine(input);*/ // não pode
}
} // feito. Mas não funciona se já estiver com letra maiúscula