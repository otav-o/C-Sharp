/*QUESTÃO 01 (2 pontos): Faça um programa que leia idades de pessoas enquanto a idade informada for maior ou igual a zero. Ao término do programa, imprima a maior idade informada pelo usuário.*/

using System;
public class Questao01 {
public static void Main(String [] args) {
	int idade = 0;
	int maior = 0;
	while (idade >= 0) {
		Console.Write("Informe uma idade: ");
		idade = Convert.ToInt32(Console.ReadLine());
		if (idade > maior) maior = idade;
	}
	Console.WriteLine("Maior idade informada: " + maior);
}
} // feito