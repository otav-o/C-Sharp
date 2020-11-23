using System;

using SistemaBancario;
namespace SistemaBancario {
    
    class Program {
        static void Main () {
            Cliente otavio = new Cliente();
            otavio.nome = "Otávio";
            otavio.idade = 20;  // define idade do cliente

            Conta c1 = new Conta();
            c1.Titular = otavio; // linha que relaciona os dois objetos. Atributo Titular de c1 aponta para o objeto otavio

            Console.WriteLine(c1.Titular.nome); // equivalente a otavio.nome 

            c1.Titular.rg = "123456789";
            c1.Titular.idade = 17; // muda idade do cliente. Mesma coisa que otavio.idade = 17, pois o objeto cliente é o mesmo.

            Console.WriteLine(c1.Titular.rg);
            Console.WriteLine(otavio.rg);

            c1.Deposita(1000);
            bool resp = c1.Saca(100); // não saca pois o cliente é menor de idade
            Console.WriteLine(resp);
            c1.ImprimeDados();
        
        /* como c1.Titular e otavio apontam para o mesmo objeto, ambos podem setar e obter atributos */

        }





















        /*static void Main() {
            Conta otavio = new Conta();
            otavio.Deposita(1000);
            otavio.Numero = 1;
            otavio.Titular = "Otávio";


            Conta ricardo = new Conta();
            ricardo.Deposita(500);
            ricardo.Numero = 2;
            ricardo.Titular = "Ricardo";

            otavio.Transfere(ricardo, 400);

            bool resp = otavio.Saca(100);

            if (resp) Console.WriteLine("Sucesso no saque!");
            else Console.WriteLine("Saldo insuficiente!");
            
            ricardo.ImprimeDados();
            otavio.ImprimeDados();
        }*/
    }
}