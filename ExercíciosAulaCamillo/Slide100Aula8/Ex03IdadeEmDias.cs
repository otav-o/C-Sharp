/*3) Faça uma função que receba a idade de uma pessoa em anos, meses e dias e retorne essa idade expressa em dias.*/

using System;
public class Ex03 {
public static int IdadeEmDias(int anos, int meses, int dias) {
	return dias + anos * 365 + meses * 30;
}
		
public static void Main (String [] args) {
	Console.WriteLine("Digite, nas três próximas linhas, a sua idade composta por anos, meses e dias, respectivamente.");
	int anos = Convert.ToInt32(Console.ReadLine());
	int meses = Convert.ToInt32(Console.ReadLine());
	int dias = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Tudo isso dá {0} dias.", IdadeEmDias(anos, meses, dias));

}
}	//feito