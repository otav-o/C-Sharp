using System;

class Animal {
	private int peso;

	public Animal() {
		peso = 120;	// pode tbm usar o pes
	}

	public int pes {	// não possui parâmetros
		
		get {
			return peso;
		}

		set {	// não confundir pes com peso!
			if (value < 0)
				peso = 0;
			else if (value > 200)
				peso = 200;
			else peso = value;

		}  // set não tem return

	}

/*
	public void pes(int peso) {
		this.peso = peso;
	}

	public int getPeso() {
		return this.peso;
	}
*/

}

class Aula41 {
	static void Main() {
		
		Animal bicho = new Animal();

		bicho.pes = 140;	// usa o acessor set
		Console.WriteLine("Peso: " + bicho.pes); // usa o get

		bicho.pes = 250;
		Console.WriteLine("Peso: " + bicho.pes);
		
		
	}
}