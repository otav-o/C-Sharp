// Coloque em um editor de código colorido para estudar

using System;
public class Aula023 {

private static void DividirTela(bool quebrarLinha = false){

	if (quebrarLinha == true) Console.Write("\n");

	Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
}
	

public static void Main (String[] args) {

	int [] vetor1 = new int[5];
	int [] vetor2 = new int[5];
	int [] vetor3 = new int[5];
	int [,] matriz = new int[2,5]{{11, 22, 00, 44, 55}, {66, 77, 88, 99, 00}};

	
/* Random */



	Random random = new Random(); // classe Random, objeto random

	for (int i = 0; i < vetor1.Length; i++) {

	// método Next do objeto random: o range vai como parâmetro. Apenas um número: range de 0 a n. Dois números: limites mínimo e máximo do sorteio. random.Next(int minimo, int maximo)

		vetor1[i] = random.Next(50); 

	}



/* Foreach */


	Console.Write("Elementos do vetor1, foreach: ");

	foreach (int elemento in vetor1) {

		Console.Write(elemento + " ");
	}

	DividirTela(true);



/* Array.BinarySearch(arrayPesquisa, valorProcurado);
   - Retorna a posição (int) do elemento procurado. 
   - O array precisa estar ordenado
   - Caso o elemento não exista no array, ele retorna -1 */



	Console.WriteLine("BinarySearch");
	int procurado = 33;

	int pos = Array.BinarySearch(vetor1, procurado); // não consegui ordenar então ele retorna um valor bugado (ex.: -6 ??)

	Console.WriteLine("Valor {0} está na posição {1}.", procurado, pos);
	DividirTela();

	

/* Array.Copy(arrOrigem, arrDestino, quantidadeElementos);
  - retorno void */


	Array.Copy(vetor1, vetor2, vetor1.Length); // e se tiverem tamanhos diferentes?

	Console.Write("(Copy) Elementos vetor2: ");

	foreach (int elemento in vetor2) {

		Console.Write(elemento + " ");

	}
	Console.Write(vetor2); // não imprime o vetor
	DividirTela(true);
	

/* arrOrigem.CopyTo(arrDestino, posicaoInicial);
   - posição inicial é a posição do array de origem a partir da qual os elementos serão copiados. */


	Console.Write("(CopyTo) Elementos vetor3: ");

	vetor1.CopyTo(vetor3, 0);

	foreach (int elemento in vetor3) {

		Console.Write(elemento + " ");
	}

	DividirTela(true);



/* int GetLowerBound(dimensão); -> retorna o menor índice do vetor ou matriz
   int GetUpperBound(dimensão); -> maior índice
	ex.: tamanho 5, GetUpperBound(dimensão) retorna 4 */



/* object GetValue (long indice); */

	Console.WriteLine(vetor1.GetValue(3));

	int valor1 = Convert.ToInt32(matriz.GetValue(1, 2));

	Console.WriteLine(valor1);


/* int Array.IndexOf(array, valor);
   - retorna a posição da primeira ocorrência do valor. -1 se não existir*/


	//int indexValor1 = Array.IndexOf(matriz, valor1);	// só funciona para matrizes unidimensionais

	int indexValor = Array.IndexOf(vetor1, vetor1.GetValue(3));
	Console.WriteLine(indexValor);
	
	DividirTela();


/* Array.Reverse(array)
   - inverte os elementos. é void*/


	Array.Reverse(vetor1);

	Console.WriteLine("(Reverse) Vetor1 invertido: ");

	foreach (int c in vetor1) {
		Console.Write(c + " ");
	}
	
	DividirTela(true);


/* arr.SetValue(object valor, long posição) */

	Console.WriteLine("(Set Value) Novo vetor2:");

	for (int i = 0; i < vetor2.Length; i++) {

		vetor2.SetValue(i, i);
		Console.Write(vetor2[i]);
	
	}
	
	DividirTela(true);

/* void Array.Sort(array);
   - põe os valores na ordem crescente 
   - use reverso para decrescente */

	Console.WriteLine("(Array.Sort) vetor1 na ordem crescente: ");
	
	Array.Sort(vetor1);

	foreach (int valor in vetor1) {
		Console.Write(valor + " ");
	}
	
	DividirTela(true);
	
}
}



	
