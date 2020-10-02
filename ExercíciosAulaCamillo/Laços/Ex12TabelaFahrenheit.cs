/*12) A conversão de graus Fahrenheit para Centígrados é obtida pela fórmula C = 5/9(F – 32). Escreva um programa que calcule e escreva uma tabela de graus centígrados em função de graus Fahrenheit que variem de 50 a 150 de 1 em 1.*/

using System;

public class Ex12 {

public static double ParaGrausCentigrados (double fahrenheit) {
	double centigrados = (double) 5 / 9 * (fahrenheit - 32); // tava dando 0 direto pois divisão inteira 5/9 é 0.
	return centigrados;
}

public static void Main (String [] args) {

	//int f = 50;	// não pode atribuir antes pois f é local no for (confirmar)
	
	
	for (int f = 50; f < 151; f++) {
		Console.WriteLine("{0}°F = {1:N2}°C", f, ParaGrausCentigrados(f)); // não precisei converter para double
	}

	Console.WriteLine(ParaGrausCentigrados(41));

}
} // feito
	
	