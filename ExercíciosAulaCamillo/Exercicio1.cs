/*
1.Faça um programa que lê uma temperatura em graus Celsius e apresenta-a convertida em graus Fahrenheit. A fórmula de conversão: F ← (9*C+160)/
*/

using System; //importa a biblioteca. Tem comandos básicos de entrada e saída.

class Exercicio1 {	
	static void Main() {	
		Console.Write("Digite uma temperatura em °C: ");
		double tempCelsius = Convert.ToDouble(Console.ReadLine());
		double tempFahrenheit = (9 * tempCelsius + 160) / 5;
		Console.WriteLine("{0}°C é o mesmo que {1}°F!", tempCelsius, tempFahrenheit);

	}
}
