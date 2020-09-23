using System;
class Aula04 {
	static int num = 10; // perceba que está dentro da classe e fora dos métodos. Variável global que só pode ser usada no método static se também for static.
	static void Main() {
		int num2 = 0;
		Console.WriteLine(num);
		// teste();	// não rola pois não é estática e não tem referência de objeto
	}

	void teste() {
		int num3 = 0;
		Console.WriteLine(num);
	}
}