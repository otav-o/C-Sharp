using System;

public interface Veiculo {

	// bool ligado; // não pode

	void ligar();	//assinatura dos métodos que serão obrigatórios
	void desligar();
	void info();
}

public interface Combate {
	void disparar();

}

class Carro:Veiculo, Combate{

	private bool ligado;
	private int municao;

	public Carro() {  // construtor é público
		this.municao = 100;
	}

	public void ligar() {
		this.ligado = true;
	}
	
	public void desligar() {
		ligado = false;	// não precisa usar o this toda hora
	}

	public void info() {}

	public void disparar() {
		municao -= 1;
	}
	

	public int muni {
			
		get {
			return municao;
		}

		set {
			municao = value;
		}
	}

	public bool lig {
		get {
			return ligado;
		}
	}


}

class Aula43 {
	static void Main() {
	
		Carro tanque = new Carro();

		Console.WriteLine("Municao: " + tanque.muni);
		tanque.muni = 150;
		Console.WriteLine("Municao: " + tanque.muni);

		tanque.ligar();
		tanque.disparar();
		Console.WriteLine("Municao: " + tanque.muni);
		
		
	}
}