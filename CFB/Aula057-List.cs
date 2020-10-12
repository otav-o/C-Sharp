using System;
using System.Collections.Generic;

class Aula56 {
static void Main() {
	
	List<string> carros = new List<string>();

	List<string> veiculos = new List<string>();

	

	carros.Add("Golf");
	carros.Add("HRV");
	carros.Add("Focus");
	carros.Add("Argo");

	veiculos.AddRange(carros); // não precisou adicionar um por um, copiou todos os elementos

	foreach (string c in carros) {
		Console.WriteLine("Carro: " + c);
	}

	Console.WriteLine("---");

	foreach (string c in veiculos) {
		Console.WriteLine("Veículo: " + c);
	}

	Console.Write("Digite um valor para checar se está na lista: ");
	string valor = Console.ReadLine();

	// nao deu certo uai (carros.Contains(valor)) ? Console.WriteLine("Não tem {0}", valor) : Console.WriteLine("Tem {0}", valor);

	if (carros.Contains(valor)) {
		Console.WriteLine("Achei {0}!", valor);
		Console.WriteLine("Está na posição " + carros.IndexOf(valor));
	} else {
		Console.WriteLine("Não encontrei " + valor);
		Console.WriteLine("Está na posição " + carros.IndexOf(valor));
	}

	string [] carros2 = new string[10];

	carros.CopyTo(carros2, 2);	// tem que ser um array normal, não copia para lista (pelo menos foi oq vi). Copia para a partir da posição 2 do array de destino

	// lista.IndexOf(valor); e se não encontrar nada?
	
	Console.WriteLine("-- array --");
	foreach(string c in carros2) {
		Console.WriteLine(c);
	} 
}
}