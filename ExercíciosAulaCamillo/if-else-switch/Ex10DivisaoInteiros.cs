/*1. Faça um programa que leia dois números inteiros e faça a divisão do primeiro pelo segundo (se o segundo for diferente de zero).*/

using System;
public class Ex10 {
public static void Main (String[] args) {
	Console.WriteLine("Digite dois números inteiros para serem divididos");
	int n1 = Convert.ToInt32(Console.ReadLine());
	int n2 = Convert.ToInt32(Console.ReadLine());
	if (n2 != 0)
		Console.WriteLine("{0}/{1}={2}", n1, n2, Convert.ToDouble(n1)/n2);
	else
		Console.WriteLine("Não é possível dividir por zero.");
	// converter só um dos dois para double faz o resultado ser double

}	// feito
}