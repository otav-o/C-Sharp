/*QUESTÃO 03 (0,5 pontos): Faça um procedimento que receba por parâmetro o valor de uma venda e imprima esse valor acrescido de 25%. A impressão deve ser feita com duas casas decimais. No método principal (Main), leia o valor da venda, e passe-o por parâmetro para o procedimento criado.*/

using System;
public class Questao03 {
static void ImprimeAcrescimo25(double valorVenda) {
	Console.WriteLine("{0} + 25% = {1:N2}", valorVenda, valorVenda * 1.25);
}
public static void Main(String[] args) {
	Console.Write("Digite o valor de uma venda para adicionar 25%: ");
	double valorInput = Convert.ToDouble(Console.ReadLine());
	ImprimeAcrescimo25(valorInput);
}} /* descobri que se o método não for estático, é necessário referenciar o objeto: Questao03.ImprimeAcrescimo25(double)*/