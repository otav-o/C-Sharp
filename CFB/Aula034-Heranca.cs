using System;

class Veiculo {	//classe base
    public int velMax;
    public int rodas;
    private bool ligado;

    public void ligar() {
	ligado = true;
    }

    public void desligar() {
	ligado = false;
    }

    public string getLigado() {
	if (ligado) return "ligado sim";
	else return "ligado não";
    }
}

class Carro: Veiculo {
    public string nome; // por padrão é private?
    public string cor;

    public Carro(string nome, string cor) {

       	//ligado = false; não funciona pois é privado

        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
        
    }
}

class Aula34 {
    static void Main() {
	Carro c1 = new Carro("Fiat", "azul");    
	Carro c2 = new Carro("Chevette", "vermelho");
	Carro c3 = new Carro("Opala", "rosa");
	
	Console.WriteLine("-=-=-=-=-=-=");

	Console.WriteLine(c1.nome);
	Console.WriteLine(c1.cor);
	Console.WriteLine(c1.velMax);
	Console.WriteLine(c1.getLigado());

	Console.WriteLine("-=-=-=-=-=-=");

	c2.velMax = 150;
	c2.ligar();
	Console.WriteLine(c2.nome);
	Console.WriteLine(c2.cor);
	Console.WriteLine(c2.velMax);
	Console.WriteLine(c2.getLigado());

	Console.WriteLine("-=-=-=-=-=-=");

	Console.WriteLine(c3.nome);
	Console.WriteLine(c3.cor);
	Console.WriteLine(c3.velMax);
	Console.WriteLine(c3.getLigado());

	Console.WriteLine("-=-=-=-=-=-=");
		
    }
}