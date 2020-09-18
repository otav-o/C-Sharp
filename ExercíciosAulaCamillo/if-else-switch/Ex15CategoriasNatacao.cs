/*6. Elabore um programa que, dada a idade
de um nadador, classifique-o em uma
das seguintes categorias:
• infantil A = 5 – 7 anos
• infantil B = 8 – 10 anos
• juvenil A = 11 – 13 anos
• juvenil B = 14 – 17 anos
• adulto = 18 – 30 anos
• sênior = maiores de 30 anos*/

using System;
public class Ex15 {
public static void Main (String[] args) {
	Console.Write("Insira a idade do nadador: ");
	int idade = Convert.ToInt32(Console.ReadLine());

	String categoria;
	if (idade >= 5 && idade <= 7) 
		categoria = "Infantil A";
	else if (idade > 7 && idade <= 10)
		categoria = "Infantil B";
	else if (idade > 10 && idade <= 13)
		categoria = "Juvenil A";
	else if (idade > 13 && idade <= 17)
		categoria = "Juvenil B";
	else if (idade <= 30)	//note que a primeira hipótese pode ser omitida pois é sempre true.
		categoria = "Adulto";
	else if (idade > 30)
		categoria = "Sênior";
	else
		categoria = "INVÁLIDA";

	Console.WriteLine("O nadador tem {0} anos e pertence à categoria {1}.", idade, categoria);
}
}	