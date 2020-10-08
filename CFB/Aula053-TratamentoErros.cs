using System;	// finally e throw new Exception(string message)


class Area {
	public static float Quadrado(float bas, float alt) { // base é palavra chave
		if (bas == 0 || alt == 0) {
			throw new Exception("Base ou altura não podem ser zero (ordens do Otávio!)");
		}
		return bas * alt;


	}

}


class Aula53 {
	static void Main() {
		int res, n1, n2;
		res = n1 = n2 = 0;

		n1 = 10;
		n2 = 2;
		
		try {
			res = n1 / n2; 

			Console.WriteLine("{0} / {1} = {2}", n1, n2, res);

			// throw new Exception ("Encontrei um erro!"); // entra no e.Message 

			// criei/forcei um erro

		} catch (Exception e) {	

			Console.WriteLine("ERRO! " + e.Message);

			Console.WriteLine(e.GetType());

		} finally {

			Console.WriteLine("Fim do processo"); // executa sempre
		}

		Console.WriteLine("--------------------");
// -----------------------------------------------------------------------------------------

		Area q1; // não posso q1.Quadrado(4, 5); pois é um método static

		float resp = Area.Quadrado(4f, 5f);

		Console.WriteLine("Área do quadrado: " + resp);

		try {
			resp = Area.Quadrado(0, 2);
		} catch (Exception oi) {
			resp = 0;
			Console.WriteLine(oi.Message);
		} finally {
			Console.WriteLine("Área do quadrado: " + resp); // sem o try catch isso aqui não executa, pois o erro está na linha anterior
		}
		

	}

}
