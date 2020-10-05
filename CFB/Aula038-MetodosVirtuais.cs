using System;
class Base {
	public Base() {
		Console.WriteLine("Construtor da classe Base");
	}

	virtual public void info() {
		Console.WriteLine("Base");
	}
}

class Derivada1: Base {
	public Derivada1() {
		Console.WriteLine("Construtor da classe derivada 1");
	}

	override public void info() {
		Console.WriteLine("Derivada1");

	}
}

class Derivada2:Derivada1 {
	public Derivada2() {
		Console.WriteLine("Construtor da classe derivada 2");
	}

	override public void info() {
		Console.WriteLine("Derivada2");
	}
}

class Aula37 {
	static void Main() {

		Base bas = new Base();
		Console.WriteLine("--------");

		Derivada1 deriv1 = new Derivada1();
		Console.WriteLine("--------");

		Derivada2 deriv2 = new Derivada2();
		Console.WriteLine("--------");
		
		bas.info();	// "Base"
        	deriv1.info();	// "Derivada1"
		deriv2.info();	// "Derivada2" 

		Console.WriteLine("-=-=-=-=-=-=-=");

		Base Ref;	// não estou vendo utilidade
		Ref = deriv2;
		Ref.info();	// "Derivada2"

		
		

	} // 11:43 05/10/2020
}