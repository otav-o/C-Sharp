using System;

class Calculadora {


	public double soma(params double[]n) {
		double soma = 0;
		foreach (double i in n) {
			soma += i;
		}
	
		return soma;
	}


	public int soma(params int[]n) {
		int soma = 0;
		for (int i = 0; i < n.Length; i++) {
			soma += n[i];
		}

		return soma;
	}

	
	public int fat(int n) {
		int res;
		if (n <= 1) {
			res = 1;  // controle de parada
		} else {
			res = n * fat(n - 1); // modificação de n
		}
		return res;
	}

}


class Aula48 {
	static void Main() {
		Calculadora calc = new Calculadora();
		int fatorial = calc.fat(5);
		Console.WriteLine(fatorial);
	



	}
}