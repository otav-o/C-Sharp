using System;
using System.Collections.Generic; // lembrar disso daqui
class Aula55 {
	static void Main() {

		Dictionary <int, string> veiculos = new Dictionary <int, string>(); // construtor genérico

		veiculos.Add(22, "Skate");
		veiculos.Add(5, "Avião");
		veiculos[4] = "Carro";
		veiculos.Add(10, "Moto");
		veiculos.Add(2, "Jegue");
		
		// veiculos.Clear(); limpa tudo		
		
		Console.WriteLine(veiculos[4]);


		Console.WriteLine("----");


		foreach (string v in veiculos.Values) {
			Console.WriteLine(v);	// imprime na ordem de criação do dicionário. Aparentemente é a ordenação padrão
		}
		

		Console.WriteLine("----");


		Console.WriteLine("Há " + veiculos.Count + " elementos nesse dicionário");
	
		veiculos.Remove(4);	// remove por chave

		Console.WriteLine("O dobro do número de elementos é {0}.", veiculos.Count * 2); // no console ficou estranho pq eu quis assim 😎



		Console.Write("Insira um valor para checar: ");

		string valor = Console.ReadLine();

		if (veiculos.ContainsValue(valor)) Console.WriteLine("{0} foi encontrado!", valor);

		else Console.WriteLine("Não encontrei " + valor);



		Console.Write("Insira uma chave para checar: ");

		int chave = int.Parse(Console.ReadLine());

		if (veiculos.ContainsKey(chave)) Console.WriteLine("A chave {0} existe nesse dicionário!", chave);

		else Console.WriteLine("Essa chave não existe :(");

		Console.WriteLine("----");


/* Outras formas de imprimir todos os elementos de um dicionário (além do dicionario.Values)*/
	// .ValueCollection

		Dictionary <int, string>.ValueCollection valores = veiculos.Values;	// uma variável do tipo valueCollection armazena todos os valores de veiculos
		
		foreach (string v in valores) {

			Console.WriteLine(v);
		}

		Console.WriteLine("----");
		
		foreach (KeyValuePair<int, string> v in veiculos) {

			Console.WriteLine(v.Key);
			Console.WriteLine(v.Value); // Key e Value estão no singular aqui (em outros casos ficam no plural)	

		}
	}
}