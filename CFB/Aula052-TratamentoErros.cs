using System;
class Aula52 {
	static void Main() {
		int res, n1, n2;
		res = n1 = n2 = 0;

		n1 = 10;
		n2 = 0;
		
		try {
			res = n1 / n2;
			Console.WriteLine("Não deu erro na linha anterior. Ufa!");
		} catch (Exception e) { // ou (DivideByZeroException e)
			Console.WriteLine("ERRO! " + e.Message);
		}

		Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
		

	}

}
