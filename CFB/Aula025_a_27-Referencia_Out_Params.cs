using System;
public class Aula025a027 {

static void Main() {

	Console.WriteLine("Digite 2 números inteiros, um por linha: ");

	int num1 = Convert.ToInt32(Console.ReadLine());

	int num2 = int.Parse(Console.ReadLine());

/* jeito convencional: número limitado de parâmetros */

	soma (num1, num2); 

/* out: você insere uma variável que vai entrar na sub-rotina como parâmetro e fazer algo lá. O valor que ela tiver ao término pode ser usado normalmente */ 

	int rest = 1;

	int quoci = divisao (num1, num2, out rest);
	
	Console.WriteLine("{0}/{1}={2}, resto {3}", num1, num2, quoci, rest);


/* Passagem por referência (ref): passa o endereço da variável como parâmetro, e não uma cópia do seu valor. Mesmo que o método seja void, vai modificar a variável! */

	// int dobroNum1 = dobro (ref num1); -> nada a ver

	dobro (ref num1); // atribuiu novo valor a num1

	Console.WriteLine("O dobro de {0} é {1}.", num1 / 2, num1);


/* Params: para 0 ou n argumentos. Usa um array flexível */

	somaDinamica (5, 10, 25, 12, 1);
	somaDinamica (1, 2);
	somaDinamica (0);
	somaDinamica ();

}





static void soma(int n1, int n2) {

	Console.WriteLine("A soma de {0} e {1} é {2}.", n1, n2, n1 + n2);

}



static int divisao(int dividendo, int divisor, out int resto) {

	int quociente = dividendo / divisor;

	resto = dividendo % divisor;

	return quociente;

}



static void dobro (ref int n) {

	n *= 2;	// mesmo sem retorno, modifica o valor que foi referenciado a n
}



static void somaDinamica (params int[] lista) {

	int resultado = 0;

	if (lista.Length == 0) 
		Console.WriteLine("Você não digitou nada uai!");

	else if (lista.Length == 1) 
		Console.WriteLine("Somar o {0} com o quê?", lista[0]);

	else {
		foreach (int valor in lista) {
			resultado += valor;
		}

		Console.WriteLine("A soma desses números deu " + resultado);
	}

}



}