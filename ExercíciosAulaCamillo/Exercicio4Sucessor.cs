/*4. Faça um programa que leia um número inteiro e imprima o seu antecessor e sucessor.*/

using System;
class Exercicio4{
	public static void Main(String[] args){
		Console.Write("Digite um número inteiro: ");
		int numero = Convert.ToInt32(Console.ReadLine());
		Console.Write("O antecessor do número {0} é o {1}, já o sucessor é {2}.", numero, numero - 1, numero + 1);
	}
}
	