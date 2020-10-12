using System;
class ex03 {
	static void Main() {

		int[] idades = new int[10]
		int i;
		for (i = 0; i < idades.Length; i++) {
			Console.Write("Idade {0}/{1}: ", i + 1, idades.Length);
			idades[i] = Convert.ToInt32(Console.ReadLine());
		}
	}	
}