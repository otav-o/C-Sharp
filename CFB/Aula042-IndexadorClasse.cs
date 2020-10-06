using System;

class Animal {
	private int[] peso = new int[5]{80, 120, 160, 240, 300};

	public Animal() {
	
	}

	public int this[int i] { // indexador que permite utilizar o objeto como array (ex.: peso[2])	
		
		get {
			return peso[i];
		}

		set {	
			if (value < 0)
				peso[i] = 0;
			else if (value > 200)
				peso[i] = 200;
			else peso[i] = value;

		}
	}

}

class Aula42 {
	static void Main() {
		
		Animal bicho = new Animal();

		Console.WriteLine("Peso: " + bicho[2]);
		bicho[2] = 140;
		Console.WriteLine("Peso: " + bicho[2]); 
		
	}
}