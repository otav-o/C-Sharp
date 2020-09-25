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

	Console.Write("Elementos do vetor1: ");
	foreach (int elemento in vetor1) {
		Console.Write(elemento + " ");
	}
	DividirTela(true);

/* BinarySearch(arrayPesquisa, valorProcurado);
   - Retorna a posição (int) do elemento procurado. 
   - O array precisa estar ordenado
   - Caso o elemento não exista no array, ele retorna -1

*/

	Console.WriteLine("BinarySearch");
	int procurado = 33;
	int pos = Array.BinarySearch(vetor1, procurado); // não consegui ordenar então ele retorna um valor bugado (ex.: -6 ??)
	Console.WriteLine("Valor {0} está na posição {1}.", procurado, pos);
	DividirTela();
	

/*Copy(arrOrigem, arrDestino, quantidadeElementos);
  - retorno void
*/

	Array.Copy(vetor1, vetor2, vetor1.Length); // e se tiverem tamanhos diferentes?
	Console.Write("(Copy) Elementos vetor2: ");
	foreach (int elemento in vetor2) {
		Console.Write(elemento + " ");
	}
	Console.Write(vetor2); // não imprime o vetor
	DividirTela(true);
	

/* arrOrigem.CopyTo(arrDestino, posicaoInicial);
   - posição inicial é a posição do array de origem a partir da qual os elementos serão copiados.
*/
	Console.Write("(CopyTo) Elementos vetor3: ");
	vetor1.CopyTo(vetor3, 0);
	foreach (int elemento in vetor3) {
		Console.Write(elemento + " ");
	}
	DividirTela(true);

	// parei no minuto 6, no GetLowerBound
}
}



	
