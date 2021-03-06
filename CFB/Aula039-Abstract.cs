/* na verdade eu mudei o exemplo para não ficar repetido, por isso as coisas não fazem sentido - ex.: peso = 0; e setAtual(); */

using System;

abstract class Livro {	// classe base abstrata
	protected int quantidadePaginas;
	protected int peso;
	protected bool atual;

	public Livro() {  // construtor não é abstrato
		atual = false;
		peso = 0;
	}


	public void setAtual(bool atual) { // atualizar e setAtual seriam a mesma coisa
		this.atual = atual; // funcionalidade deve ser implementada
	}


	public int getPeso() {
		return peso;
	}


	abstract public void aumentarPeso(int peso); // setVelAtual
		// this.peso += peso; // não pode pois é abstract. Deixar com ponto e vírgula, jamais com chaves
	
}

class Revista:Livro {

	public Revista() {
		quantidadePaginas = 120;
		atual = true;
	}

	override public void aumentarPeso(int peso) {
		this.peso += peso;
	} 
	// sem isso não compila
	
}

class Aula39 {
static void Main () {

	// Livro livro = new Livro(); // não dá para instanciar

	Revista livro1 = new Revista();

	Console.WriteLine(livro1.getPeso());	//0
	livro1.aumentarPeso(50);
	Console.WriteLine(livro1.getPeso());
}
}