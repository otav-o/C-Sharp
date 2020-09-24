/*4. Dada uma dívida de 10000 reais que cresce a juros de 2,5% ao mês e uma aplicação de 1500 reais com rendimento de 4% ao mês, escrever um algoritmo que determina o número de meses necessários para pagar a dívida.*/

using System;
public class Ex04 {

public static void Main(String[] args) {
	Console.Write("Digite o valor da dívida: R$");
	double valorDivida = Convert.ToDouble(Console.ReadLine());
	Console.Write("Agora digite a taxa de juros a.m. em decimal: ");
	double taxaJuros = Convert.ToDouble(Console.ReadLine());
	Console.Write("Quanto de dinheiro você tem aplicado? R$");
	double dinheiroAplicado = Convert.ToDouble(Console.ReadLine());
	Console.Write("E quanto de juros isso rende a.m.? ");
	double rendimentoAplicacao = Convert.ToDouble(Console.ReadLine());
	double meses;

	/*10000 + 10000 * 0.025 ^ meses = 1500 + 1500 * 0.04 ^ meses
	valorDivida * Math.Pow(taxaJuros, meses) == dinheiroAplicado * Math.Pow(rendimentoAplicacao, meses); 
	acho que n da para fazer equação*/

	while (true) {
		meses = 0;
		valorDivida *= taxaJuros;
		dinheiroAplicado *= rendimentoAplicacao;
		if (valorDivida <= dinheiroAplicado)
			break;
		meses += 1;
	}
	Console.WriteLine("Essa dívida será paga em {0} meses.", meses);
}
}