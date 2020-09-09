/*3) Faça uma função que receba o valor de um produto e um percentual de acréscimo. A função deve retornar o valor do produto após a aplicação do acréscimo.*/

using System;
public class Ex03 {

static double Acrescimo(double valor, double porcentagem) {
	double valorFinal = valor * (1 + porcentagem/100);
	return valorFinal;
}

static void Main(String[] args) {
	Console.Write("Digite o preço-base: ");
	double valor = Convert.ToDouble(Console.ReadLine());
	Console.Write("Quantos % de aumento? ");
	double acrescimo = Convert.ToDouble(Console.ReadLine());
	Console.Write("{} + {}% = {}.", valor, acrescimo, Acrescimo(valor, acrescimo));
	}
}