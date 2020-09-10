/*QUESTÃO 04 (0,5 pontos): Faça uma função que receba uma string por parâmetro. A string recebida por parâmetro deve ser impressa pela função e, em seguida, a função deve ler e retornar um número inteiro.*/

using System;
public class Questao04 {
static int ImprimirERetornarInteiro(String texto) {
	Console.WriteLine("O número digitado foi {0}.", texto);
	int numero = Convert.ToInt32(texto);
	return numero;
}
/*acabei de checar e vi que o programa não atende ao enunciado. Vou reescrever em outro documento*/

public static void Main(String[] args) {
	Console.WriteLine("O próximo número é " + (Questao04.ImprimirERetornarInteiro("450")+1));

	String saudacao = "oi";
	Console.WriteLine(saudacao + "abc");	// parece que em C# String pode começar com letra maiúscula


}}
	
