/*Faça um programa que leia uma string e imprima os três últimos caracteres da string lida. A string lida deve ser totalmente impressa caso a mesma tiver menos de 3 caracteres.*/

using System;
class AtividadeRegis {
    static void Main() {
        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine();
        int antePenultimoIndice = texto.Length - 3;
        if (antePenultimoIndice < 0) antePenultimoIndice = 0;
        for (int i = antePenultimoIndice; i <= texto.Length - 1; i++) {
            Console.Write(texto[i]);
        }
    }
}