/*13) Faça um programa que leia dois números inteiros e imprima "Divisível” se o primeiro número lido for divisível pelo segundo número lido ou imprima “Não divisível” caso contrário.*/

using System;
class Ex013 {
public static void Main(String[] args) {
	Console.Write("Digite um número inteiro: ");
	int n1 = Convert.ToInt32(Console.ReadLine());
	Console.Write("Digite outro número inteiro: ");
	int n2 = Convert.ToInt32(Console.ReadLine());
	if (n1 % n2 == 0) {
		Console.WriteLine("{0} é divisível por {1}!", n1, n2);
	} else {
		Console.WriteLine("{0} não é divisível por {1}.", n1, n2);
	}
}
} //tudo certo
	