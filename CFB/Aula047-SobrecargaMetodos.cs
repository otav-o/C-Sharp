using System;

class Calc {


	public double soma(params double[]n) {
		double soma = 0;
		foreach (double i in n) {
			soma += i;
		}
		Console.WriteLine("Método 1 (params)");
		return soma;
	}


	public int soma(params int[]n) {
		int soma = 0;
		for (int i = 0; i < n.Length; i++) {
			soma += n[i];
		}
		Console.WriteLine("Método 2 (params)");
		return soma;
	}





	public int soma(int n1, int n2) {
		Console.WriteLine("Método 3");
		return n1 + n2;
	}

	public double soma(double n1, double n2) {
		Console.WriteLine("Método 4");
		return n1 + n2;			// parâmetros não são iguais pois é double
	}
	
	public int soma(int n1, int n2, int n3) {
		Console.WriteLine("Método 5");
		return n1 + n2 + n3;
	}


}

class Aula47 {
	static void Main() {
		Calc calculadora = new Calc();

		var res = calculadora.soma(10, 5);

		Console.WriteLine(res);

		Console.WriteLine(calculadora.soma(1, 2, 3));

		Console.WriteLine(calculadora.soma(10, 10, 10, 10));

		Console.WriteLine(calculadora.soma(10.4, 30.2));

		Console.WriteLine(calculadora.soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

		Console.WriteLine(calculadora.soma(1.5, 13.2, 1.53));

		



	}
}