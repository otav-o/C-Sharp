/*6) Considerando o critério de aprovação de uma disciplina que determina que um aluno está aprovado se a média ponderada de suas três provas for maior ou igual a 5.0, onde a média é dada pela fórmula:

Média = (P1 + P2 + 2.0 * P3) / 4.0

(a) Escreva uma função que receba como parâmetros as notas das duas primeiras provas de um aluno (P1 e P2) e retorne a nota mínima que o aluno precisa tirar na terceira prova para que seja aprovado.
(b) Escreva um programa em C# completo que leia do teclado as duas primeiras notas de um aluno, calcule e imprima a nota mínima que o aluno precisa tirar na P3 para que seja aprovado. Este programa deve fazer uso da função do item anterior.*/

using System;
public class Ex06 {
public static double NotaMinimaTerceiraProva (double nota1, double nota2) {
	double notaMinima = (20 - nota1 - nota2)/2;
	return notaMinima;
}
public static void Main (String[] args) {
	Console.Write("Insira a primeira nota: ");
	double nota1 = Convert.ToDouble(Console.ReadLine());
	Console.Write("Insira a segunda nota: ");
	double nota2 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Com essas notas, você precisará tirar {0} na última prova.", NotaMinimaTerceiraProva(nota1, nota2));
	Console.Write("Insira sua terceira nota: ");	// bom para testar
	double nota3 = Convert.ToDouble(Console.ReadLine());
	double media = (nota1 + nota2 + 2 * nota3) / 4;
	if (media >= 5) 
		Console.WriteLine("Você foi aprovado com média {0}! Parabéns.", media);
	else
		Console.WriteLine("Você foi reprovado. O mínimo a ser tirado é 5, e você tirou {0} :(", media);
	}
} // ótimo