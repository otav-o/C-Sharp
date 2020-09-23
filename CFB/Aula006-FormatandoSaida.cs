// 08:22 23/09/2020
using System;
class Aula006 {
static void Main() {
	double valorCompra = 5.50;
	double valorVenda; // se não atribuir dá erro
	double lucro = 0.1;
	valorVenda = valorCompra + valorCompra * lucro;
	//valorVenda = valorCompra *= lucro;	// nada a ver

	Console.WriteLine("O valor da compra é:\t\t{0}\nO valor da venda é:\t\t{1}\nO lucro é:\t\t{2}", valorCompra, valorVenda, lucro);
	// \t adiciona tabulação, \n quebra a linha

	string produto = "Pastel";
	Console.WriteLine("Produto......:{0,15}", produto);
	Console.WriteLine("Val.Compra...:{0,15:c}", valorCompra);
	Console.WriteLine("Lucro........:{0,15:p}", lucro);
	Console.WriteLine("Val.Venda: {0,15:c}", valorVenda);

	}
	// 15 é em quantos caracteres o índice vai ser impresso. Tem que adaptar para ficar alinhado, já que os caracteres serão contados a partir do que tem antes.
	// c: formatação monetária, p: porcentagem
}