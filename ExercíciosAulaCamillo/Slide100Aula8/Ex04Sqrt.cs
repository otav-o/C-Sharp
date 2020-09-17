/*4) Faça uma função que receba dois números reais, a e b, e retorne o valor de ( A2 + B2)1/2. Observação: para calcular a raiz quadrada será preciso utilizar a função Math.Sqrt(). [perdi a formatação ao copiar]*/

using System;
public class Ex04 {
public static double RaizDaSomaDosQuadrados(double a, double b) {
	return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

}
public static void Main (String[] args) {
	Console.WriteLine("Digite dois números, um por linha: ");
	double n1 = Convert.ToDouble(Console.ReadLine());
	double n2 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Raíz de {0}^2 + {1}^2 é igual a {2}.", n1, n2, RaizDaSomaDosQuadrados(n1, n2));

	Console.WriteLine(Math.Sqrt(n1));
	Console.Write(Math.Pow(n1, 1/2)); // percebi que não funciona
}
} // deu certo. Dica: testar com 30 e 40.