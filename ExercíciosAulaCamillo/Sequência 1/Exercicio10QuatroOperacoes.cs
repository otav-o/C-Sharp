/*10. Escreva um programa para efetuar as quatro operações matemáticas básicas (adição, subtração, produto e divisão) sobre dois valores informados.*/

using System;
class Exercicio10 {
	public static void Main (String [] args) {
		Console.Write("Digite um número: ");
		double n1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Agora digite outro: ");
		double n2 = Convert.ToDouble(Console.ReadLine());

		char resp = '0';

		while (true) {
			Console.Write("=-=- Tabela -=-=\nDigite 1 para soma\nDigite 2 para subtração\nDigite 3 para multiplicação\nDigite 4 para divisão\n");
			resp = Convert.ToChar(Console.ReadLine());
			if (resp == '1') {
				Console.WriteLine("A soma dá " + (n1 + n2));
				break;
			} else if (resp == '2') {
				Console.WriteLine("A subtração dá " + (n1 - n2));
				break;
			} else if (resp == '3') {
				Console.WriteLine("A multiplicação resulta " + (n1 * n2));
				break;
			} else if (resp == '4') {
				Console.WriteLine("A divisão dá " + (n1/n2));
				break;
			} else {
				Console.WriteLine("Algo deu errado.");
			}
		}

	}
}
/*meus erros: não coloquei break
	não pus aspas simples nos if/else if para char
*/