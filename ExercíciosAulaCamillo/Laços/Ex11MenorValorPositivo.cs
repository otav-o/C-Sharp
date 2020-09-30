/*11) Faça um programa que, dado um conjunto de valores inteiros e positivos (fornecidos um a um pelo usuário), determine qual o menor valor do conjunto. O final do conjunto de valores é conhecido através do valor zero, que não deve ser considerado.*/

using System;

public class Ex11 {

public static void Main(String[] args) {
	
	int valor = 1;
	int menor = 0;
	int i = 0;

	while (valor != 0) {
	
		Console.Write("Insira um inteiro positivo: ");

		valor = Convert.ToInt32(Console.ReadLine());

		if (valor == 0) break;
		
		if (i == 0) menor = valor;
		
		if (valor < menor) menor = valor;
		
		i++;

	}

	Console.WriteLine("O menor valor inserido é " + menor);
}
} // ok. Queria fazer sem usar o break


	
	
	