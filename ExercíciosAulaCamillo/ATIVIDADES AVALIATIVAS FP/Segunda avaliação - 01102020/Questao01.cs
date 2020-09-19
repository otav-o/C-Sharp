/*QUESTÃO 01 (1 ponto): Faça uma função que retorne o maior entre três números reais passados por parâmetro. No método principal (Main), faça a leitura de três números reais, chame a função passando-os por parâmetro e imprima o resultado da função.*/

using System;
public class Questao01 {
	public static double MaiorDeTres(double n1, double n2, double n3) {
		double maior = n1;
		if (n2 > n1 && n2 > n3)
			maior = n2;
		else if (n3 > n1 && n3 > n2)
			maior = n3;
		return maior;
	}

	public static void Main(String[] args) {
		Console.WriteLine("Digite 3 números reais, um por linha: ");
		double n1 = Convert.ToDouble(Console.ReadLine());
		double n2 = Convert.ToDouble(Console.ReadLine());
		double n3 = Convert.ToDouble(Console.ReadLine());
		double maior = MaiorDeTres(n1, n2, n3);
		Console.WriteLine("O maior entre os números {0}, {1} e {2} é {3}.", n1, n2, n3, maior);
	}

		// funciona
}
		
		