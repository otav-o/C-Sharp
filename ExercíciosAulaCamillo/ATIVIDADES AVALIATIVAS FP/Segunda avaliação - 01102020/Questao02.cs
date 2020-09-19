/*QUESTÃO 02 (1 ponto): Faça um procedimento que receba por parâmetro o ano atual e o ano de nascimento de uma pessoa. O procedimento deve imprimir a idade dessa pessoa e, em seguida, imprimir se a pessoa é bebê (0 a 3 anos), criança (4 a 10 anos), adolescente (11 a 18 anos), adulta (19 a 60 anos) ou idosa (61 anos em diante). No método principal (Main), leia o ano de nascimento da pessoa e o ano atual e passe-os por parâmetro para o procedimento criado. Observação: como não é solicitado o mês de aniversário, o cálculo da idade deve ser feito levando-se em conta somente o ano.*/

using System;
public class Questao02 {
	public static void IdadeComFaixaEtaria (int anoAtual, int anoNascimento) {
		int idade = anoAtual - anoNascimento;
		String tipo = "";
		if (idade >= 0 && idade <= 3)
			tipo = "bebê";
		else if (idade <= 10)
			tipo = "criança";
		else if (idade <= 18)
			tipo = "adolescente";
		else if (idade <= 60)
			tipo = "adulto";
		else if (idade > 60)
			tipo = "idoso";
	
		Console.WriteLine("Essa pessoa tem {0} anos e é um(a) {1}.", idade, tipo);

	} 

	public static void Main(String[] args) {
		Console.Write("Qual o ano de nascimento? ");
		int anoNasc = Convert.ToInt32(Console.ReadLine());
		Console.Write("E o ano atual? ");
		int anoAtual = Convert.ToInt32(Console.ReadLine());
		IdadeComFaixaEtaria(anoAtual, anoNasc);
	}
}