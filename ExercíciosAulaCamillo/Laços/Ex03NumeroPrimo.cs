/*3. Ler um número inteiro e positivo e verificar se este é ou não um número primo.*/
using System;
public class Ex03 {
static void Main() {
	Console.Write("Digite um número inteiro positivo: ");
	int numero = Convert.ToInt32(Console.ReadLine());
	bool primo = true;
	for (int i = 2; i < numero; i ++) {
		if (numero % i == 0) {
			primo = false;
			break;
		}
	}
	if (primo == true)
		Console.WriteLine("{0} é primo!", numero);
	else if (primo == false)
		Console.WriteLine("{0} não é primo.", numero);
}
} // funciona bem
		
			
		