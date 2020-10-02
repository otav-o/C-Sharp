/*13) Elabore um programa que calcule N! (fatorial de N), sendo que o valor inteiro de N é fornecido pelo usuário. Sabendo que 0! = 1, por definição.*/

using System;

public class Ex13 {

public static void Main () {

	Console.Write("Digite um número inteiro: ");

	int n = Convert.ToInt32(Console.ReadLine());
	
	int fatorial = 1;

	for (int i = n; i > 1; i--) {
		fatorial *= i;
	}

	Console.WriteLine("{0}! = {1}", n, fatorial);
}
} // feito
	