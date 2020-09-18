/*2) Ler um número inteiro e informar se ele é divisível por 2.*/

using System;
class Ex02 {
public static void Main (String[] args) {
	Console.Write("Informe um número inteiro: ");
	int numero = Convert.ToInt32(Console.ReadLine());
	if (numero % 2 == 0) 
		Console.WriteLine("Esse número é divisível por 2.");
	else
		Console.WriteLine("Esse número não é divisível por 2.");
}
}