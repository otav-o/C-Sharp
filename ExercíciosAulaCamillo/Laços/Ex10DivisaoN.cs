/*10) Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o valor de E = 1 + 1/1! + 1/2! + 1/3! + ... + 1/N! */


using System;
public class Ex10 {

public static double fatorial(int n) {

	double fat = 1;
	for (int i = n; i > 1; i--) {
		fat *= i;
	}
	return fat;

} // testei e funciona

public static void Main(String[] args) {
	
	double soma = 0;
	
	Console.Write("Digite um número inteiro positivo: ");

	int n = Convert.ToInt32(Console.ReadLine());

	for (int i = 1; i <= n; i++) {	

		soma += 1/fatorial(i);
	}


	Console.WriteLine("A soma dá " + soma);


	}

}	// como saber que acertei?


