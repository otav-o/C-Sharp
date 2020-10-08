using System;

class Aula51 {
	static void Main(string[] o) { 	// pelo visto o array pode ter qualquer nome, não precisa ser args

		if (o.Length > 0) {
			Console.WriteLine("Quantidade de argumentos: " + o.Length);
			for (int i = 0; i < o.Length; i++) {
				Console.WriteLine("{0} na posição {1}", o[i], i);
			}
		} else {
			Console.WriteLine("Não foram passados argumentos");
		}
		
	}
}