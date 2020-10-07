using System;

struct Carro {
	public string marca;
	public string cor;

	public void info() {
		Console.WriteLine("Marca.: " + this.marca);
		Console.WriteLine("Cor...: " + cor);
		Console.WriteLine("--------------------");
	}	
}

class Aula45 {
	static void Main() {

		Carro [] concessionaria = new Carro[4];
		concessionaria[0].marca = "HRV";
		concessionaria[0].cor = "Prata";
		
		concessionaria[1].marca = "Golf";
		concessionaria[1].cor = "Azul";

		concessionaria[2].marca = "Jetta";
		concessionaria[2].cor = "Branco";
	
		concessionaria[3].marca = "Argo";
		concessionaria[3].cor = "Preto";	// carros implementados no array concessionaria

		foreach (Carro c in concessionaria) {	// posso dizer que classes criam tipos?
			c.info();
		}

		concessionaria[0].info();
		concessionaria[1].info();
		concessionaria[2].info();
		concessionaria[3].info();
		

	}
}