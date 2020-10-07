using System;		/*entendi nada*/

class Galinha {
	private string nomeGalinha;
	private int numOvo;

	public Galinha(string nomeGalinha) {
		this.nomeGalinha = nomeGalinha;
		numOvo = 0;
	}

	public Ovo botar() {	// Ovo é tipo de retorno
		numOvo++;
		return new Ovo(numOvo, nomeGalinha); // chama o construtor
	} 

}


class Ovo {
	private int numOvo;
	private string minhaGalinha;
 
	public Ovo(int numOvo, string minhaGalinha) {
		
		this.numOvo = numOvo;
		this.minhaGalinha = minhaGalinha; // desnecessário?
		Console.WriteLine("Ovo criado: {0}.{1}", this.minhaGalinha, this.numOvo);

	}

}

class Aula46 {
	static void Main() {
		Galinha g1 = new Galinha("Beneditasgildimar");
		Galinha g2 = new Galinha("Felizbertaniazilda");
		Galinha g3 = new Galinha("MarisGertrudeszela");
		
		
		g1.botar(); // 1
		g1.botar();
		g1.botar();

		g2.botar();
		g2.botar();

		g3.botar();
		g3.botar();
		g3.botar(); // 8	// controle parcial dos ovos da galinha. Para criar um geral, usar um static	
	}
}