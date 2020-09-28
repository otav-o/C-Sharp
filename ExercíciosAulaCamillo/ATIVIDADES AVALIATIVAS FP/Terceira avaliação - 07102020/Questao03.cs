/*QUESTÃO 03 (1 ponto): Faça uma função que não receba parâmetros e retorne um número positivo informado pelo usuário. A função deve solicitar um número inteiro para o usuário e, enquanto o usuário não informar um número positivo, a função deve solicitar novamente que o usuário informe um número positivo. Assim que o usuário informar um número positivo, a função deve retornar o número positivo informado. No método principal (Main), imprima o retorno dessa função.*/

using System;
public class Questao03 {

public static int retornarPositivo() {
	int numero = -1;
	while (numero < 0) {
		Console.Write("Informe um número positivo: ");
		numero = Convert.ToInt32(Console.ReadLine());
	}
	return numero;
}
	
public static void Main (String[] args) {
	Console.WriteLine("Número informado pelo usuário: " + retornarPositivo());

} // feito
}	