/*8. Imprimir o valor 2.346728 com 1, 2, 3 e 5 casas decimais.*/

using System;
class Exercicio8{
	public static void Main(String[] args){
		Console.Write("Digite um valor com muitas casas decimais: ");
		float valor = Convert.ToSingle(Console.ReadLine());
		Console.WriteLine("Número: {0}.\nCom 1 casa decimal: {0; f1}.\nCom duas casas: {0; f2}.\nCom 3 casas: {0; f3}.\nCom 5 casas: {0; f5}.", valor);
	}
}