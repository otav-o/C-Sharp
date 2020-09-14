/*14) Faça uma função que retorne o maior entre três números reais passados por parâmetro. No método principal (Main), faça a leitura de três números reais, chame a função passando-os por parâmetro e imprima o resultado da função.*/

using System;
public class Ex014 {
	static double MaiorDe3(double n1, double n2, double n3) {
		if (n1 > n2 && n1 > n3) {
			return n1;
		} else if (n2 > n1 && n2 > n3) {
			return n2;
		} else if (n3 > n1 && n3 > n2) {
			return n3;
		} else {
			return n1;
		}
	}

public static void Main (String[] args) {
	Console.WriteLine("Insira três números reais, um por linha:");
	double input = Convert.ToDouble(Console.ReadLine());
	double input1 = Convert.ToDouble(Console.ReadLine());
	double input2 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("O maior número digitado foi " + MaiorDe3(input, input1, input2));
}
} // funciona.