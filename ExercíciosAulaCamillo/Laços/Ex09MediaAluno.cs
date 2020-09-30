/*9) Escreva um algoritmo que leia a matrícula de um aluno e suas três notas. Calcule a média ponderada do aluno, considerando que o peso para a maior nota seja 4 e para as duas restantes, 3. Mostre ao final a média calculada e uma mensagem "APROVADO" se a média for maior ou igual a 5 e "REPROVADO" se a média for menor que 5. Repita a operação até que o código lido seja negativo.*/

using System;
public class Ex09 {
public static void Main (String[] args) {
	double matricula = 0;
	double nota = 0;
	double somaNotas = 0;
	double maiorNota = 0;
	double media = 0;
	string estado = "";


	while (matricula >= 0) {
		Console.Write("Digite sua matrícula: ");
		matricula = Convert.ToDouble(Console.ReadLine());
		if (matricula < 0) break;
		for (int i = 0; i < 3; i++) {
			Console.Write("Digite a nota {0}:", i + 1);
			nota = Convert.ToDouble(Console.ReadLine());
			if (nota > maiorNota) maiorNota = nota;
			somaNotas += nota;
				
		}
		
	
		somaNotas -= maiorNota;	// só resta o somatório das de peso 3
		somaNotas = (maiorNota * 4 + somaNotas * 3);
		media = somaNotas / (4 + 3 + 3);
		if (media >= 5) estado = "APROVADO"; else estado = "REPROVADO";
 
		Console.WriteLine("Sua média foi: {0}, você está {1}!!", media, estado);
	
	}
} // feito
} /* demorei muito mas consegui. Onde errei: 
	1. Teste do while no início não encerra o programa imediatamente;	
	2. Fiquei inventando rotina onde não tinha
	3. Esqueci que a média ponderada divide pelo somatório dos pesos (eu tinha esquecido de somar o outro 3, estava dando 7 e não 10)
*/
