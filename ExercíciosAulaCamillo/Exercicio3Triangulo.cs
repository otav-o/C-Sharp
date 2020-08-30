/*
3.Faça um programa que leia os valores dos lados e altura de um triângulo, calcule e imprima seu perímetro e área. 20:09 30/08/2020
*/
using System;
class Exercicio3 {
	public static void Main(String[] args) {
		Console.WriteLine("Calculadora de triângulos");
		Console.Write("Digite a altura: ");
		int altura = Convert.ToInt32(Console.ReadLine());
		Console.Write("Qual é o primeiro lado? ");
		int lado1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("E o segundo? ");
		int lado2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Digite a medida do último: ");
		int lado3 = Convert.ToInt32(Console.ReadLine());
		
		//descobrindo a base (o maior lado)
		int bbase; //n pode. base é palavra reservada
		bbase = 0; //não pode haver o risco de ela ficar sem valor
		/*if (lado1 == lado2 == lado3){
			bbase = lado1;
		}*/
		
		if (lado1 > lado2 && lado1 > lado3){
			bbase = lado1;
		}
		if (lado2 > lado1 && lado2 > lado3){
			bbase = lado2;
		}
		if (lado3 > lado1 && lado3 > lado2){
			bbase = lado3;
		}
		double area = bbase*altura/2;
		// Console.WriteLine("-=" * 20); não pode
		Console.WriteLine("O perímetro desse triângulo é {0} e sua área é {1}.", lado1 + lado2 + lado3, area);


}
}

		/*for (c = 0; c < 3; c++){
			Console.write("Digite o lado " + c + ": ")
			lado
			desisti :(*/