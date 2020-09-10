/*QUESTÃO 02 (0,5 pontos): Faça um programa que leia cinco números inteiros e imprima a média dos números lidos.*/

using System;
public class Questao02 {
public static void Main (String[] args) {
	Console.WriteLine("Insira 5 números inteiros, um por linha: ");
	int n1 = Convert.ToInt32(Console.ReadLine());
	int n2 = Convert.ToInt32(Console.ReadLine());
	int n3 = Convert.ToInt32(Console.ReadLine());
	int n4 = Convert.ToInt32(Console.ReadLine());
	int n5 = Convert.ToInt32(Console.ReadLine());
	double media = (double) (n1 + n2 + n3 + n4 + n5)/5;
	Console.Write("A média entre esses números é " + media + ".");
	
}}
	