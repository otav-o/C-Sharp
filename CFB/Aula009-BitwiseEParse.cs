using System;
public class Aula009 {
	static void Main() {
		Console.Write("Vamos testar operações bitwise e testar conversão com Parse\nDigite um valor: ");
		var n1 = Convert.ToInt32(Console.ReadLine()); // pelo visto, o Console.Read() não espera você digitar
		Console.Write("Agora digite outro número: ");
		int n2 = int.Parse(Console.ReadLine()); // outra forma de converter 
		
		
		int metadeN2 = n2 >> 1;	// significa que vai deslocar para a direita um algarismo binário (divide por dois)
		int dobroN1 = n1 << 1;	// bitwise para esquerda
		int quadruploN2 = n2 << 2;	// dobra duas vezes
		
		const int numero = 4;
		Console.WriteLine("{0} x 2 = {2}\n{1} / 2 = {3}\n{1} x 4 = {4}", n1, n2, dobroN1, metadeN2, quadruploN2);
}
}
		
		