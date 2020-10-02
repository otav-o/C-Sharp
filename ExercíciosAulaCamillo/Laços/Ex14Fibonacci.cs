/*14) Fazer um programa para calcular e mostrar os N primeiros termos da série de Fibonacci. O número N é fornecido pelo usuário. A série de Fibonacci é gerada da seguinte forma:
f1 = 1
f2 = 1;
f3 = f1 + f2 = 2;
f4 = f2 + f3 = 3;....
f5 = f4 + f3 = 5;
f6 = f5 + f4 = 8;

O primeiro e segundo termos valem 1 e os seguintes são calculados somando os dois termos anteriores.*/

using System;

class Ex14 {

static void Main() {
	
	Console.Write("Digite um número inteiro: ");

	int n = Convert.ToInt32(Console.ReadLine());

	int termo1 = 1;
	int termo2 = 1;
	int numero = 0;

	Console.WriteLine("Termo 1: 1\nTermo 2: 1");

	for (int i = 3; i < n + 1; i++) {
		numero = termo1 + termo2;

		termo1 = termo2;
		termo2 = numero; // recebe a soma
		
		Console.WriteLine("Termo {0}: {1}", i, numero);
	}
}
} // feito. Conferi a sequência na internet