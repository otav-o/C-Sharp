/*5) Considere as equações de movimento para calcular a
posição (s) e velocidade (v) de uma partícula em um
determinado instante t, dado sua aceleração a, posição inicial
s0 e velocidade inicial v0, de acordo com as fórmulas:

s = s0 + v0*t + (a * t * t)/2
v = v0 + a*t

Escreva um programa C# completo que capture os valores
de s0, v0, a e t, fornecidos pelo usuário via teclado, e calcule
e imprima os valores de s e v.*/

using System;
public class Ex05 {
public static double VelocidadeMUV(double v0, double a, double t) {
	double v = v0 + a * t;
	return v;
}
public static double PosiçãoMUV(double s0, double v0, double a, double t) { // pelo visto pode usar cedilha e ~
	double s = s0 + v0 * t + (a/2 * Math.Pow(t, 2));
	return s;
}
public static void Main (String [] args) {
	Console.WriteLine("Digite, nesta sequência, os seguintes valores (um por linha): s0, v0, a e t.");
	double s0 = Convert.ToDouble(Console.ReadLine());
	double v0 = Convert.ToDouble(Console.ReadLine());
	double a = Convert.ToDouble(Console.ReadLine());
	double t = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("No tempo {0} segundos, a velocidade será {1} na posição {2}.", t, VelocidadeMUV(v0, a, t), PosiçãoMUV(s0, v0, a, t));
	}
}
// não conferi os cálculos, mas o programa funciona