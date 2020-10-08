using System;

delegate int Op(int num1, int num2);

class Matematica {

	public static int soma(int n1, int n2) {
		return n1 + n2;
	}

	public int multi(int n1, int n2) {
		return n1 * n2;
	}
}

class Aula50 {
	static void Main() {
	
	int res;
	Op d1 = new Op(Matematica.soma); // precisa referenciar a classe pois é static

	res = d1(3, 4);
	Console.WriteLine("Soma: " + res);

	Matematica oi = new Matematica();

	d1 = new Op(oi.multi);	// como é não-estático, precisei criar um objeto
	
	res = d1(3, 4);
	Console.WriteLine("Multiplicação: " + res);	
	}
} // estudar isso