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

	double meses = 0;

	

	while (valorDivida >= dinheiroAplicado) {

		valorDivida *= 1 + taxaJuros;
		dinheiroAplicado *= 1 + rendimentoAplicacao;
		meses += 1;

	}

	Console.WriteLine("Essa dívida será paga em {0} meses.", meses);
}
} // deu 131 meses. E tem que colocar vírgula no .Net brasileiro, com ponto ele buga
  // parece que funciona