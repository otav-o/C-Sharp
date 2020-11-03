/*QUESTÃO 01 (1 ponto): Faça uma função que receba por parâmetro uma string e retorne o
número de vogais existentes na string recebida por parâmetro.*/

using System;
class Questao1 {
    static int qtdVogais(string texto) {
        int qtd = 0;
        char letra = ' ';
        for (int i = 0; i < texto.Length; i++) {

            if (texto[i] > 'a') // se for minúscula
                letra = texto[i]; // deixar minúscula
            else                    // senão
                letra = Convert.ToChar(texto[i] - 'A' + 'a'); // converter para minúscula

            switch (letra) {
                case 'a': case 'e': case 'i': case 'o': case 'u': qtd++; break; default: break;
            }
        }
        return qtd;
    }
    static void Main() {
        Console.Write("Digite um texto: ");
        Console.WriteLine(qtdVogais(Console.ReadLine()) + " vogais encontradas!!");
    }
}// funciona
