using System;

namespace SistemaBancario2 {
    
    class Program {
        static void Main () {
            Cliente otavio = new Cliente("Otávio");
            otavio.Idade = 20; 

            Conta c1 = new Conta();
            c1.Titular = otavio; 

            Console.WriteLine(c1.Titular.Nome); 

            c1.Titular.Rg = "123456789";
            c1.Titular.Idade = 17; 

            Console.WriteLine(c1.Titular.Rg);
            Console.WriteLine(otavio.Rg);

            c1.Deposita(1000);
            bool resp = c1.Saca(100);
            Console.WriteLine(resp);
            c1.ImprimeDados();
        


        }


    }
}