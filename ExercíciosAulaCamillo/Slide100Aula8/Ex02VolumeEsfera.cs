/*2) Faça uma função que receba por parâmetro o raio de uma esfera e calcule o seu volume: v = (4 * PI * R3) /3.*/

using System;
public class Ex02 {
public static double VolumeEsfera(double raio) {
	return (4 * Math.PI * Math.Pow(raio, 3))/3;
}
public static void Main (String[] args) {
	Console.Write("Digite o raio da esfera: ");
	double input = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("O volume da esfera de raio {0} é {1:N2}.", input, VolumeEsfera(input));
}
}	// funciona

	