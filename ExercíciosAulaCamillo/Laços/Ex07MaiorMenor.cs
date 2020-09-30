/*7) Escreva um algoritmo que leia 10 valores (usando a mesma variável) e encontre o maior e o menor deles. Mostre o resultado.*/
using System;

public class Ex07 {

public static void Main (String[] args) {

	double maior = 0; // precisa atribuir antes do if else
	double menor = 0;

	for (int i = 0; i < 10; i++) {

		Console.Write("Digite o {0}° valor: ", i + 1);
		double valor = Convert.ToDouble(Console.ReadLine());

		if (i == 0) {
			maior = valor;
			menor = valor;
		}

		else if (valor > maior) maior = valor;
		else if (valor < menor) menor = valor;
	}

	Console.WriteLine("O menor valor é {0} e o maior é {1}.", menor, maior);
}
} // feito		

