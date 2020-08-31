/*5. Construa um programa que aplique um desconto de 25% sobre o preço de um produto recebido como entrada e imprima o valor resultante.*/

using System;
class Exercicio5 {
	public static void Main (String[] args){
		Console.Write("Insira o valor do produto: ");
		double valor = Convert.ToInt32(Console.ReadLine());
		Console.Write("O valor do produto com 25% de desconto é {0} (antes custava {1}).", valor * 0.75, valor);
}}
		