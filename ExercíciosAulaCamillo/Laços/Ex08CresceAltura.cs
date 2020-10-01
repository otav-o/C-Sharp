/*8) Chico tem 1,50 metros e cresce 2 centímetros por ano, enquanto Zé tem 1,40 metros e cresce 3 centímetros por ano. Construa um algoritmo que calcule e imprima quantos anos serão necessários para que Zé seja maior que Chico.*/

using System;
public class Ex08 {

public static void Main (String[] args) {

	double alturaChico = 1.5, alturaZe = 1.4;

	double crescimentoChico = 0.02;
	double crescimentoZe = 0.03;
	int anosPassados = 0;

	while (alturaChico >= alturaZe) {

		alturaZe += crescimentoZe;
		alturaChico += crescimentoChico;
		anosPassados += 1;

	} // já que não dá para fazer equação

	Console.WriteLine("Após " + anosPassados + " anos, Zé será maior que Chico.");

}
}  // minha resposta: 11 anos. - correto

/*for (qtdeanos = 0; alturaChico >= alturaZe; alturaChico += 0.02, alturaZe += 0.03, qtdeanos++)*/

	