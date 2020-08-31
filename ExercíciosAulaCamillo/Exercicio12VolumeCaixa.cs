/*12. Elaborar um programa que calcule e apresente o volume de uma caixa retangular, por meio da fórmula: 09:29 31/08/2020*/

using System;
class Exercicio12 {
	public static void Main (String [] args) {
		Console.WriteLine("-=-= Volume de uma caixa -=-=");
		Console.Write("Qual o comprimento? (m) ");
		double comprimento = Convert.ToDouble(Console.ReadLine());
		Console.Write("E a largura? ");
		double largura = Convert.ToDouble(Console.ReadLine());
		Console.Write("Por último, digite a altura: ");
		double altura = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("O volume de uma caixa de dimensões {0}m x {1}m x {2}m é {3}m³!", comprimento, largura, altura, comprimento * largura * altura);
		Console.ReadKey();
	}
}