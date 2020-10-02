using System;

public class APS1 {

public static void Main (String[] args) {

	

	double sobra = 0;

	double pesoEncomenda = 0;

	double pesoEntrega = 0;

	double pesoMaximo = 0;

	String nome = "";

	double maiorEntrega = 0;	
	
	String maiorNome = "";


	do {

		Console.Write("Digite o nome do ciclista: ");
	
		nome = Console.ReadLine();

		Console.Write("Qual o peso máximo que {0} pode carregar? ", nome);

		pesoMaximo = Convert.ToDouble(Console.ReadLine());

		int i = 1;
		
		pesoEntrega = 0;


		do {
			
	
			Console.Write("Digite o peso da encomenda {0}: ", i);
	
			pesoEncomenda = Convert.ToDouble(Console.ReadLine());

			if (i == 1) {pesoEntrega += sobra; sobra = 0;}

			pesoEntrega += pesoEncomenda;
		
			i++;



		} while (pesoEntrega <= pesoMaximo && pesoEncomenda > 0);


		if (pesoEntrega > pesoMaximo) {

			pesoEntrega -= pesoEncomenda;
			
			sobra = pesoEncomenda;
		}
	


		if (pesoEntrega > maiorEntrega) {

			maiorEntrega = pesoEntrega;

			maiorNome = nome;

		}
		
	} while (pesoEncomenda > 0);



	
	Console.WriteLine("O entregador {0} carregou o maior peso, {1} kg no total.", maiorNome, maiorEntrega);
}
} // terminei e entreguei esse daqui

