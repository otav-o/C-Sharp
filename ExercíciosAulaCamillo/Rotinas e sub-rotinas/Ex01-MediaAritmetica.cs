/*1) Faça um procedimento que receba três valores reais e imprima a média aritmética desses valores.*/

using System;
public class Ex01 {
	public static void Main(String [] args) {
	Console.WriteLine("Digite três números, um por linha");
	double n1 = Convert.ToDouble(Console.ReadLine());
	double n2 = Convert.ToDouble(Console.ReadLine());
	double n3 = Convert.ToDouble(Console.ReadLine());
	Console.Write("A média entre " + n1 + ", " + n2 + " e " + n3 + " é " + MediaAritmetica(n1, n2, n3));
	
}
static double MediaAritmetica(double n=0, double n1=0, double n2=0){
		double media = (n + n1 + n2)/3;
		return media; //tem que ficar dentro do class
	}
}
	
	