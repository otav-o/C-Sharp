/*Crie uma classe para representar uma pessoa, com os atributos privados de nome, data de nascimento e altura. Crie os métodos públicos necessários para sets e gets e também um método para imprimir todos dados de uma pessoa. Crie um método para calcular a idade da pessoa.*/

using System;
class Pessoa {
	private string nome;
	private int dataNasc;
	private int altura;

	public Pessoa(string nome, int dataNasc, int altura) {
		this.nome = nome;
		this.dataNasc = dataNasc;
		this.altura = altura;
	}	

	public void imprimirDados() {
		Console.WriteLine("Nome: {0}; Nascimento: {1}; Altura: {2}", nome, dataNasc, altura);
	}

	public void setNome(string nome) {
		this.nome = nome;
	}

	public void setDataNasc(int dataNasc) {
		this.dataNasc = dataNasc;
	}

	public void setAltura(int altura) {
		this.altura = altura;
	}

	public string getNome() {
		return nome;
	}

	public int getDataNasc() {
		return dataNasc;
	}

	public int getAltura() {
		return altura;
	}

}
// a resposta sugerida utiliza uma estrutura que eu nunca vi (get e set juntos)

class Principal {
	static void Main() {
		Pessoa p1 = new Pessoa("Oi", 261, 180);
		p1.imprimirDados();

		p1.setNome("Otávio");
		p1.setDataNasc(569);
		p1.setAltura(230);
		
		p1.imprimirDados();
		
	}
} // ok