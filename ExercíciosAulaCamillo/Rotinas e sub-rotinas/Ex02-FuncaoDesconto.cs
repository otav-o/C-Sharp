/*2) Faça uma função que receba o valor de um produto e um percentual de desconto. A função deve retornar o valor do produto após a aplicação do desconto.*/

using System;
public class Ex02 {
	static double AplicarDesconto(double valorProduto=0, double porcentagemDesconto=0) {
		double valorFinal = valorProduto * (1-porcentagemDesconto/100);
		return valorFinal;
	}

public static void Main(String[] args){
	Console.Write("Digite o valor do produto: ");
	double a = Convert.ToDouble(Console.ReadLine());
	Console.Write("Qual a % de desconto? ");
	double b = Convert.ToDouble(Console.ReadLine());
	Console.Write("O valor final é {}.", AplicarDesconto(a, b));
}
}