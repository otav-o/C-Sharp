/*1) Faça um procedimento que receba por parâmetro o tempo de duração de um experimento expresso em segundos e imprima na tela esse mesmo tempo em horas, minutos e segundos.*/

using System;
public class Ex01 {
	static void ConversorTempo(int segundos) {
		int minutos = segundos / 60;
		int segundosRestantes = segundos % 60;
		int horas = minutos / 60;
		int minutosRestantes = minutos % 60;

		Console.WriteLine("{0} segundos são o mesmo que {1} horas, {2} minutos e {3} segundos.", horas, minutosRestantes, segundosRestantes);
}


	static void ConversorTempoCamillo(int totalSegundos) {
		int horas, minutos, segundos;
		horas = totalSegundos / 3600;
		totalSegundos = totalSegundos % 3600;
		
		minutos = totalSegundos / 60;
		segundos = totalSegundos % 60;

		Console.WriteLine({0} horas