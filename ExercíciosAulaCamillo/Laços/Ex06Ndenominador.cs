/*6) Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o valor de E = 1 + 1/2 + 1/3 + ... + 1/N */
using System;
public class Ex06 {
public static void Main(String[] args) {
	Console.Write("Digite um inteiro positivo: ");
	int n = int.Parse(Console.ReadLine());
	double resultado = 0;	// precisa atribuir
	for (int i = 1; i <= n; i++) {
		resultado += (double) 1/i;	// só assim funcionou
	}
	
	Console.WriteLine("O resultado é {0}.", resultado);
} // não dá para checar se tá certo, mas funciona
}