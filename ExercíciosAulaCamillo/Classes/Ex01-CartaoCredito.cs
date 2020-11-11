/*Defina uma classe para representar as informações de um cartão de crédito. No método Main, instancie dois objetos do tipo da classe criada, atribua valores a cada atributo dos objetos e imprima todos os atributos do segundo objeto instanciado*/


using System;
namespace Ex01 {
static class CartaoCredito1 { // essa classe vai ser estática e com atributos públicos
    static public string titular;  // os membros também precisam ser estáticos
    static public string dataValidade;
    static public int cvv; 

    static public void imprimir() {
        Console.WriteLine("Titular: {0}\nData de validade: {1}\nCVV: {2}", titular, dataValidade, cvv);

    }
}

class CartaoCredito2 { // classe com atributos públicos
    public string titular;
    public string dataValidade;
    public int cvv;

    public void imprimir() {
        Console.WriteLine("Titular: {0}\nData de validade: {1}\nCVV: {2}", titular, dataValidade, cvv);

    }
} 

class Ex01 {
    static void Main() {
        // CartaoCredito1 c1 = new CartaoCredito1(); // não dá para instanciar objetos de classes estáticas. Nem compila.
        CartaoCredito1.titular = "Otávio";
        CartaoCredito1.dataValidade = "05/28";
        CartaoCredito1.cvv = 120;

        CartaoCredito1.imprimir();

        CartaoCredito2 c1 = new CartaoCredito2();
        c1.titular = "Ricardo";
        c1.dataValidade = "10/21";
        c1.cvv = 000;

        c1.imprimir();

    }
} // feito mas está ruim
}