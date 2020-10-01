using System;

public class Jogador {
	
	public int energia = 100;

	public bool vivo = true;

}

public class Aula028 {	

	static void Main() {
		
		Jogador j1 = new Jogador(); // objeto j1 da classe Jogador
		Jogador j2 = new Jogador();
		
		j1.energia = j1.energia/2;		

		Console.WriteLine(j1.energia); // 50
		Console.WriteLine(j2.energia); // 100 (objetos são independentes)

	}

}