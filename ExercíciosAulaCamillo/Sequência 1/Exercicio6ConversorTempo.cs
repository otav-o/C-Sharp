/*6. Construa um programa para ler um intervalo de tempo em segundos, converter para horas, minutos e segundos e imprimir o resultado.*/

using System;
class Exercicio6{
	public static void Main (String[] args){
		Console.WriteLine("Bem vindo(a) ao conversor de tempo. Insira o tempo em segundos na próxima linha");
		int segundosEntrada = Convert.ToInt32(Console.ReadLine());

		int minutos = segundosEntrada/60;	//forçar o desprezo das casas decimais
		double segundosRestantes = segundosEntrada % 60;
		int horas = minutos/60;		// horas completas
		int minutosRestantes = minutos % 60; 
		
		Console.WriteLine("{0} segundos são o mesmo que {1} horas, {2} minutos e {3} segundos.", segundosEntrada, horas, minutosRestantes, segundosRestantes);
	}
}
		