/*QUESTÃO 02 (2 pontos): Faça um programa que leia 5 números inteiros informados pelo usuário. Essa leitura precisa acontecer em um comando de repetição do tipo “for”. Ao término do programa, imprima a soma e a quantidade de números pares digitados pelo usuário.*/

using System;
public class Questao02 {
public static void Main (String[] args) {
	int somaPares = 0;
	int numero = 0;
	int quantidadePares = 0; // não consegui fazer múltipla atribuição
	for (int i = 0; i < 5; i++) {
		Console.Write("Informe um número inteiro: ");
		numero = Convert.ToInt32(Console.ReadLine());
		if (numero % 2 == 0) {somaPares += numero; quantidadePares += 1;}
	}
	Console.WriteLine("Soma dos pares: {0}\nQuantidade de pares: {1}", somaPares, quantidadePares);
}	// feito
}
	