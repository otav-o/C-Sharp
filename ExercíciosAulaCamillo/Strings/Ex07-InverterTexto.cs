/*7) Crie um procedimento que receba uma string e imprima a string invertida.
Exemplo: Entrada: Teste Saída: etseT*/

using System;

class Ex07 {
    static void imprimeInvertido(string s) {
        for (int i = s.Length - 1; i >= 0; i--) {
            Console.Write(s[i]);
        }
    }
    static void Main(){
        Console.Write("Digite um texto: ");
        imprimeInvertido(Console.ReadLine());
    }
} // feito. Excelente