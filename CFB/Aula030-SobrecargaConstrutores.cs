using System;

public class Jogador {

	public int energia;

	public bool vivo;

	public string nome;

	public Jogador (string n) {
		energia = 100;
		vivo = true;
		nome = n;
	}

	public Jogador () {
		energia = 100;
		vivo = true;
		nome = "Jogador";
	}

	public Jogador (string n, int e) {
		energia = e;
		vivo = true;
		nome = n;
	}

	
	public Jogador (string n, int e, bool v) {
		energia = e;
		vivo = v;
		nome = n;
	}

	public void Info() {	// precisa ser void (mas os construtores, não)
		Console.WriteLine("Nome jogador: {0}", nome);
		Console.WriteLine("Energia: " + energia);
		Console.WriteLine("Estado: " + vivo);
	}



	~Jogador() { 	// destrutor
		Console.WriteLine("Jogador {0} foi destruído.", nome);
	}

}

class Aula30 {

static void Main () {
	
// toda hora chama um construtor diferente

	Jogador j1 = new Jogador();
	Jogador j2 = new Jogador ("Bruno");
	Jogador j3 = new Jogador ("Théo", 50);
	Jogador j4 = new Jogador ("Zigofreudo", 30, true);
	Jogador j5 = new Jogador ("Benegundesfirno", 0, false);

	j1.Info();	// faz a impressão
	j2.Info();
	j3.Info();
	j4.Info();
	j5.Info();
}
} // para ter sobrecarga: precisam ter o mesmo nome, mas um conjunto de parâmetros diferente