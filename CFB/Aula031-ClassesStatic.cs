using System;

static public class Jogador {

	static public int energia;
	static public bool vivo;
	static public string nome;

	static public void iniciar (string n) {
		energia = 100;
		vivo = true;
		nome = n;
	}

	static public void Info() {
		Console.WriteLine("Nome jogador: {0}", nome);
		Console.WriteLine("Energia: " + energia);
		Console.WriteLine("Estado: " + vivo);
	}

}

class Inimigo {

	static public bool alerta;	// inseri o static para todos os objetos mudarem ao mesmo tempo
	public string nome;

	public Inimigo(string n) {
		alerta = false;
		nome = n;
	}

	public void info() {
		Console.WriteLine(nome);
		Console.WriteLine(alerta);
		Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
	}

}




class Aula31 {

static void Main () {
    
    	Jogador.iniciar("Otávio");	// acessa-se pela própria classe. Só é possível um jogador?
	Jogador.Info();


    	
	Inimigo i1 = new Inimigo("Doido");
	
	Inimigo i2 = new Inimigo("Maluco");

	Inimigo i3 = new Inimigo("Pirado");


		// i1.alerta = true; // dá certo quando alerta não é static


	Inimigo.alerta = true;	// muda pela classe pois agora coloquei alerta como static

	i1.nome = "oi"; // pode pois nome não é estático


	i1.info();
	i2.info();
	i3.info();

	

}
}