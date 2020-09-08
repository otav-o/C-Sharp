/*
2.Faça um programa que lê um valor de salário mínimo e o salário de um funcionário. O programa deve calcular e imprimir quantos salários mínimos esse funcionário ganha.
*/

using System;
class Exercicio2 {
	static void Main(string[] args) {
		Console.Write("Insira o valor do seu salário: ");
		double salarioTotal = Convert.ToDouble(Console.ReadLine());
		int salarioMinimo = 1045;
		double numeroSalarios = salarioTotal/salarioMinimo;
		Console.Write("R$" + salarioTotal + " representa um total de " + numeroSalarios + " salários mínimos!");
	}
}