/*Dada uma tabela contendo a idade de 10 alunos, faça um algoritmo que calcule o número de alunos com idade superior à média*/

using System;

class ex03 {

static void Main() {

	int [] idades = new int[] {18, 19, 30, 21, 25, 27, 29, 25, 20, 18};

	double media = 0;
	int soma = 0;

	for (int i = 0; i < idades.Length; i++) {

		soma += idades[i];

	}

	media = soma/idades.Length;

	int quantidadeAcima = 0;

	foreach (int idade in idades) {

		if (idade > media) {

			Console.WriteLine("A idade {0} é maior que a média ({1})", idade, media);

			quantidadeAcima++;
		}
	}

	Console.WriteLine(quantidadeAcima + " idades são maiores que a média");	
}	


}