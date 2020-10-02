/* versão ruim e errada. Entreguei o outro código (APS1-2.cs). tchau */

using System;
public class Aps1 {
public static void Main(String[] args) {

	double sobra = 0;
	String nomeMaior = "";
	double maiorEntrega = 0;
	double pesoEntrega = 0;
	double pesoParcial = 0;

	while (true) {

		Console.Write("Digite o nome do ciclista: ");
		String nome = Console.ReadLine();
		Console.Write("Qual o máximo que {0} pode carregar? (kg) ", nome);
		double maxCiclista = Convert.ToDouble(Console.ReadLine());


		pesoEntrega = 0 + sobra;
		sobra = 0;
		pesoParcial = 0;
		int cont = 1;


		while (maxCiclista > pesoEntrega) {
			Console.Write("Digite o peso da encomenda {0}: ", cont);
			pesoParcial = Convert.ToDouble(Console.ReadLine());
			if (pesoParcial <= 0) goto final;
			pesoEntrega += pesoParcial;
			cont++;
		}

		if (pesoEntrega > maxCiclista) {
			pesoEntrega -= pesoParcial;
			if (pesoParcial == 0) // se não entrar no while
				sobra = pesoEntrega;	// preservar a sobra antiga
			else
				sobra = pesoParcial;
			
		}

		if (pesoEntrega > maiorEntrega && cont != 1) { 
			nomeMaior = nome;
			maiorEntrega = pesoEntrega;
		}
	}

	final:
		Console.WriteLine("{0} foi o entregador que carregou mais peso, {1}kg no total.", nomeMaior, maiorEntrega);
	

	
}}






























/*
	double sobra = 0;
	inicio:

	Console.Write("Digite o nome do ciclista: ");
	String nome = Console.ReadLine();
	Console.Write("Qual o máximo que {0} pode carregar? (kg) ", nome);
	double maxCiclista = Convert.ToDouble(Console.ReadLine());

	double pesoEntrega = 0 + sobra;
	double pesoParcial = 0;
	int cont = 1;
	
	while (true) {
		Console.Write("Digite o peso da encomenda {0}: ", cont);
		pesoParcial = Convert.ToDouble(Console.ReadLine());
		if (pesoParcial <= 0) break;	
		pesoEntrega += pesoParcial;
		if (pesoEntrega >= maxCiclista) {
			Console.WriteLine("Peso máximo excedido. Direcionando ao próximo entregador...");
			pesoEntrega -= pesoParcial;
			sobra = pesoParcial;
			goto inicio;
		}
	}
	
}
}




*/





/*





























	double sobra = 0;	
	do {
		Console.Write("Digite o nome do ciclista: ");
		String nomeCiclista = Console.ReadLine();
		Console.Write("Digite a carga máxima que {0} pode carregar (kg): ", nomeCiclista);
		double pesoMaxCiclista = Convert.ToDouble(Console.ReadLine());

		double pesoEntrega = 0 + sobra;
		double pesoEncomenda = 0;
		int cont = 1;

		while(pesoEntrega <= pesoMaxCiclista) {
			Console.Write("Qual o peso da encomenda {0}? ", cont);
			pesoEncomenda = Convert.ToDouble(Console.ReadLine());
			if (pesoEncomenda <= 0) goto final;
			pesoEntrega += pesoEncomenda;
			if (pesoEntrega >= pesoMaxCiclista) {
				Console.WriteLine("Limite ultrapassado. Deixando para o próximo ciclista...");
				pesoEntrega -= pesoEncomenda;
				sobra = pesoEncomenda;
				break; // sair do while(true)
			}
			cont++;

		}
	} while (sobra > 0);
	final:
	Console.WriteLine("O programa foi encerrado.");
	




}
}
	*/
	
	
	
	