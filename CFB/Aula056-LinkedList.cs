using System;
using System.Collections.Generic; // esquece não ein

class Aula56 {
static void Main() {
	LinkedList <string> transporte = new LinkedList <string>();

	transporte.AddFirst("Carro");
	transporte.AddFirst("Aviao");
	transporte.AddFirst("Navio");
	transporte.AddFirst("Motocicleta"); // vai ser impresso primeiro

	transporte.AddLast("Bicicleta");

		// transporte.AddAfter("Navio", "Charrete"); nada a ver

		// no = "Navio"; não pode

	LinkedListNode<string> no;

	no = transporte.FindLast("Navio");
	transporte.AddAfter(no, "Charrete");

	no = transporte.FindLast("Motocicleta").Next; // next e previous apontam para o próximo/anterior item. No caso, next indica "Navio".

	transporte.AddBefore(no, "Patinete");	// inserido antes de "Navio"

	Console.WriteLine(no.Value);
	Console.WriteLine(no.Previous.Value);	// anterior a navio: patinete


	Console.WriteLine("---");

	foreach (string v in transporte) {
		Console.WriteLine(v);
	}

	Console.WriteLine("---");

	// transporte.Clear(); apaga tudo

	
	// transp.Find("Carro");   retorna a referência para o elemento ou null

	

	if (transporte.Find("Carro") == null) {

		Console.WriteLine("Não encontrado");

	} else {
		
		Console.WriteLine("Elemento encontrado");
	
	}

	Console.WriteLine("---");

	transporte.Remove("Navio");

	transporte.RemoveFirst();

	transporte.RemoveLast();

	foreach (string v in transporte) {
		Console.WriteLine(v);
	}

	Console.WriteLine("---");
	
	


}
}