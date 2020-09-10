/*QUESTÃO 04 (0,5 pontos): Faça uma função que receba uma string por parâmetro. A string recebida por parâmetro deve ser impressa pela função e, em seguida, a função deve ler e retornar um número inteiro.*/

using System;
public class UltimaQuestao {
static int ImprimirERetornarInteiro2(String texto) {
	Console.WriteLine("Você digitou o seguinte texto: {0}", texto);
	Console.Write("Agora, digite um número inteiro: ");
	String numero = Console.ReadLine();
	return Convert.ToInt32(numero);
}
public static void Main(String[] args){
	int retorno = ImprimirERetornarInteiro2("olá, eu gosto de comprar coisas em promoção.");
	Console.WriteLine("O número digitado foi {0} e seu sucessor é {1}.", retorno, retorno + 1);
	

}}