/*5. Calcular o valor de S = 2/50 + (2^2)/48 + (2^3)/46 + ... + (2^25)/2*/
using System;
public class Ex05 {
public static void Main(String[] args) {
	int denominador = 50;
	int expoente = 1;
	double resultado = 0;
	while (expoente <= 25 && denominador >=2) {
		resultado += Math.Pow(2, expoente)/denominador;
		expoente++;
		denominador -= 2;
	}
	Console.WriteLine("O resultado dessa expressão é {0}.", resultado);
}


// rodou mas não sei se está correto
}















/*for (denominador; denominador >= 25; denominador - 2) {
		for (expoente; expoente <= 25; expoente++) {
			resultado += Math.Pow(2, expoente)/denominador;
		}
	}não serve*/