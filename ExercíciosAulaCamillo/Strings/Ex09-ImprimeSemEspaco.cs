/*9) Fazer um procedimento para imprimir uma string recebida como parâmetro sem os espaços em branco.*/

using System;
class Ex09 {
    static void imprimeSemEspaco(string s) {
        for (int i = 0; i < s.Length; i++) {
            if (s[i] != ' ') Console.Write(s[i]);
        }
    }
    static void Main() {
        Console.Write("Digite um texto: ");
        imprimeSemEspaco(Console.ReadLine());
    }
} // feito. Ótimo