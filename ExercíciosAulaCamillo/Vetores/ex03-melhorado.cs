using System;
class ex03 {
	static void Main() {

		Console.Write("Quantas idades você quer adicionar? ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		int[] idades = new int[n];

		int i, soma = 0;
		
		for (i = 0; i < idades.Length; i++) {
			Console.Write("Idade {0}/{1}: ", i + 1, idades.Length);
			int entrada = Convert.ToInt32(Console.ReadLine());
			idades[i] = entrada;
			soma += entrada;
		}
		double media = soma/idades.Length;
		Console.Write("A média de idades é: " + media + ". Estas são maiores que a média: ");

		for (i = 0; i < idades.Length; i++) {
			if (idades[i] > media) {
				Console.Write(idades[i] + " ");
			}
		}
	}	// feito
}