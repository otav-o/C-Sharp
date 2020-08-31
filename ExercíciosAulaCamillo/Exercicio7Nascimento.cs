/*7. Fazer um programa para imprimir na primeira linha o dia, na segunda linha o mês e na terceira o ano de seu nascimento. 07:34 31/08/2020 */

using System;
class Exercicio7 {
	public static void Main (String[] args){
		Console.Write("Digite o dia do seu nascimento: ");
		String dia = Console.ReadLine();
		Console.Write("Agora o mês: ");
		String mes = Console.ReadLine();
		Console.Write("O ano: ");
		String ano = Console.ReadLine();
		char resp = '0';
		while (resp != '1' && resp != '2') {
			Console.Write("Escolha o formato da data - digite 1 para recebê-la em uma linha ou 2 para várias linhas. ");
			resp = Convert.ToChar(Console.ReadLine()); //não existe conversão implícita
			if (resp != '1' && resp != '2') {
				Console.WriteLine("Resposta inválida. Tente novamente.");
			}
		}
		if (resp == '1'){
			Console.WriteLine("Você nasceu no dia {0}/{1}/{2}.", dia, mes, ano);
		} else if (resp == '2') {
			Console.WriteLine("Dia: " + dia);
			Console.WriteLine("Mês: " + mes + "\nAno: " + ano);
		}
	}
}
			
		