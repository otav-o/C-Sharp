using System;

struct Carro {
	public string marca;
	public string modelo;
	public string cor;

	public Carro(string marca, string modelo, string cor) {
		this.marca = marca;
		this.modelo = modelo;
		this.cor = cor;
	}
		
}

class Aula44 {
	static void Main() {
		Carro c1;	// sem chamar o construtor

		c1.marca = "VW ";	// é possível pois é public
		c1.modelo = "Fusca ";
		c1.cor = "Verde";

		Console.WriteLine(c1.marca + c1.modelo + c1.cor);


		Carro c2 = new Carro("Nissan ", "Versa rebaixado ", "Azul ");

		Console.WriteLine(c2.marca + c2.modelo + c2.cor);

	}
}