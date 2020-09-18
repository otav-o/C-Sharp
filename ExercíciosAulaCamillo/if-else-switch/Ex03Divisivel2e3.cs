/*3) Altere o algoritmo anterior para que seja informado se o número é divisível por 2 e por 3 simultaneamente.*/

using System;
class Ex03 {
public static void Main (String[] args) {
	Console.Write("Informe um número inteiro: ");
	int numero = Convert.ToInt32(Console.ReadLine());
	if (numero % 2 == 0 && numero % 3) 
		Console.WriteLine("Esse número é divisível por 6.");
	else
		Console.WriteLine("Esse número não é divisível por 6.");
}
}