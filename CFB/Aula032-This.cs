using System;
class Calculos {
	public int v1; // é representado pelo this
	public int v2;
	
	public Calculos (int v1, int v2) {
		/*v1 = v1;
		v2 = v2;*/
		
		this.v1 = v1;
		this.v2 = v2;
		
	}
	public int Somar() {
		return v1 + v2;
	}
}

class Aula32 {
static void Main() {
	Calculos c = new Calculos(10, 2);

	Console.WriteLine(c.v1); // 10
	Console.WriteLine(c.v2); // 2
	Console.WriteLine(c.Somar()); // 12


	// Console.WriteLine(Somar(4, 2)); - não existe no contexto atual
}

}