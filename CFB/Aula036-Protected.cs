using System;
class Doce {	// base
	public int acucar;
	private int sodio;	// restringe à classe
	protected bool saudavel;
	
	public Doce (int sodio) {
		acucar = 0;
		this.sodio = sodio;
        	saudavel = false;
	}

    	public bool getSaudavel() {
        	return saudavel;
    	}

    	public int getSodio() {
        	return sodio;
    	}
}

class DoceFesta:Doce { // derivada de Doce
    	public string nome;

    	public DoceFesta(string nome, int s):base(s) { 	// o valor será passado para o Doce(int sodio)

        	this.nome = nome;
   		// sodio = s não pode (private)
        
        	saudavel = true; // pode pois é classe derivada (pode falar "sub-classe?")
   
    	}
}
class Aula36 {
    	static void Main() {
        	Doce d1 = new Doce(40);
	        DoceFesta d2 = new DoceFesta("Goiabada", 30);
        

        	Console.WriteLine(d1.acucar); // 0
        
        	// Console.WriteLine(d1.sodio);  // erro; sodio é privado

        	Console.WriteLine(d1.getSodio()); // 40
        
        	// Console.WriteLine(d1.nome); // não tem
        
        	// Console.WriteLine(d1.saudavel); // erro; é protected

        	Console.WriteLine(d1.getSaudavel()); // false
        
		Console.WriteLine("-=-=-=-=-=-=");

        	Console.WriteLine(d2.acucar); // 0
        	// Console.WriteLine(d2.sodio); // erro; sodio é privado
        	Console.WriteLine(d2.getSodio()); // 30
        	Console.WriteLine(d2.nome); // Goiabada
        
        	// Console.WriteLine(d2.saudavel); // erro, é protected (apesar de ser acessado na classe derivada)
        
        	Console.WriteLine(d2.getSaudavel()); // true pois a classe derivada definiu assim
        
        
    	}
}