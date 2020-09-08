/*9. Fazer um programa para ler o valor de um produto (em reais) e o valor de um desconto (em reais). Imprima o valor do produto após a aplicação do desconto. Dica: declare duas variáveis: valorProduto e valorDesconto, sendo ambas do tipo double. Exemplo de leitura da variável valorProduto: valorProduto = Convert.ToDouble(Console.ReadLine())*/

using System;
class Exercicio9 {
	public static void Main (String[] args){
		Console.Write("Qual o valor do produto? R$");
		double valorProduto = Convert.ToDouble(Console.ReadLine()); //pula linha automaticamente
		Console.Write("Qual o desconto? R$");
		double valorDesconto = Convert.ToDouble(Console.ReadLine());
		Console.Write("O valor final é {0} e o desconto foi de {1}%.", valorProduto - valorDesconto, valorDesconto/valorProduto*100);


	}
}
/*erros: esqueci de colocar o tipo na declaração
dúvidas: como converter para float? 
Por que o .NET em portugues usa vírgula??? que merda*/