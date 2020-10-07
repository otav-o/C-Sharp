using System;

class Mat {

	public static double pi = 3.14;

	public static int dobro (int n) {
		return n * 2;
	}
}

class Aula49 {
	static void Main() {
		double vPi = Mat.pi; // propriedade ou variável estática

		Console.WriteLine(vPi);

		int num = 10;

		Console.WriteLine("O dobro de {0} é {1}", num, Mat.dobro(10));n // função estática
	
	}
}