/*1) Ler dois números inteiros e informar se o primeiro valor lido é maior, menor ou igual ao segundo.*/

using System;
public class Ex02 {
public static void Main(String[] args) {
	Console.WriteLine("Digite dois números, um por linha");
	double n1 = Convert.ToDouble(Console.ReadLine());
	double n2 = Convert.ToDouble(Console.ReadLine());
	double maior = 0;
	if (n1 > n2) 
		maior = n1;
	else if (n1 < n2)
		maior = n2;
	else
		Console.WriteLine("Não há um número maior");
	if (maior != 0)
	Console.WriteLine("{0} é maior que {1}", maior, menor);
}
}
	


	