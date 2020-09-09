/*4) Escreva um procedimento que recebe dois números inteiros e imprime, a soma, o produto, a diferença, o quociente e o resto entre esses dois números.*/

using System;
public class Ex04{
public static void OperacoesMatematicas(int n1, int n2) {
	Console.WriteLine("A soma dá " + (n1 + n2)); //sem parênteses não soma
	Console.WriteLine("A diferença é " + (n1 - n2));
	Console.WriteLine("O produto é " + (n1 * n2));
	Console.WriteLine("O quociente é " + (n1/n2));
	Console.WriteLine("O resto da divisão é " + (n1 % n2));
}
public static void Main(string[] args){
	Console.WriteLine("Digite dois números inteiros, um em cada linha:");
	int n1 = Convert.ToInt32(Console.ReadLine());
	int n2 = Convert.ToInt32(Console.ReadLine());
	OperacoesMatematicas(n1, n2);

}}

//feito