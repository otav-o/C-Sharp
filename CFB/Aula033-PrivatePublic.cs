using System;
class Jogador {
	private int energia;
	private string nome;
	public int idade = 14;
    
	public Jogador(string nome) {
		this.nome = nome;
		energia = 100;
		//idade = 14;  não precisa estar no construtor se já foi definido anteriormente
		
	}

    	public int getEnergia() {  // óbvio que não precisa ser esse nome
        	return energia;
    	}
    	public string getNome() {
        	return nome;
    	}
    
    	public void setEnergia(int e) { // na verdade diminui energia
        	energia += e;
        	if (energia > 100) energia = 100;
        	if (energia < 0) energia = 0;
    	}
}
class Aula33 {
	static void Main() {

	Jogador j1 = new Jogador("Ronaldo");

	// Console.WriteLine(j1.nome);
	// Console.WriteLine(j1.energia);

        j1.setEnergia(-30);

	j1.idade = 2509877; // modificado livremente, sem filtro

        Console.WriteLine(j1.getNome());
        Console.WriteLine(j1.getEnergia());
	Console.WriteLine(j1.idade); // public
	}
}