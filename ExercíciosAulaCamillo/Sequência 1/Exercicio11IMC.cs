/*11. Elaborar um programa que calcule o índice de massa corporal (IMC) de um usuário qualquer, sabendo-se que o IMC é determinado pela divisão da massa do indivíduo (em quilogramas) pelo quadrado de sua altura (em metros).*/

using System;
class Exercicio11 {
	public static void Main (String [] args) {
		Console.WriteLine("-=-= Calculadora de IMC =-=-");
		Console.Write("Insira o peso (em kg): ");
		double massa = Convert.ToDouble(Console.ReadLine());
		Console.Write("Agora a altura (em m): ");
		double altura = Convert.ToDouble(Console.ReadLine());

		double imc = massa/(altura * altura); //não consegui altura ** 2
		Console.WriteLine("O IMC dessa pessoa é " + imc);
		Console.ReadKey();
	}
}

/*erros: Convert.ToDouble - esqueci do ponto
	não fechei esse comentário
  dúvidas: Existe operação de exponenciação? tipo ** ou ^
  Math.Pow(altura, 2); -> elevar altura ao quadrado
*/