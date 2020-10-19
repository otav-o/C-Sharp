/*4. Faça um algoritmo para ler e somar dois vetores de 10 elementos inteiros. Imprima ao final os valores dessa soma, elemento a elemento.*/

using System;

public class OperacaoVetores {
   public void somarVetores(int[] vetor, int[] vetor2) {
      for (int i=0; i < vetor.Length; i++) {
         Console.WriteLine("{0} + {1} = {2}", vetor[i], vetor2[i], vetor[i] + vetor2[i]);
      }
   }
}
   
class Ex04 {
   static void Main() {
      OperacaoVetores conta = new OperacaoVetores();
      Random aleatorio = new Random();
	  
      int [] array = new int[10];
      int [] array2 = new int[10];

      /*foreach (int elemento in array){
         elemento = aleatorio.Next(0, 100);
      }*/

       for (int i = 0; i< array.Length; i++) {
         array[i] = aleatorio.Next(0, 100);
      }

      for (int i = 0; i< array2.Length; i++) {
         array2[i] = aleatorio.Next(0, 100);
      }
      
      conta.somarVetores(array, array2);
   }
} // feito