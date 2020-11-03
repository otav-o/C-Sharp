/*11) Fazer um programa para ler uma string e transferir as consoantes para uma string e as vogais para outra. Depois mostre cada uma das strings.*/

using System;

namespace oi {
class Ex11:oi.Ex10 { // não consegui fazer a herança
    
    static void Main() {

        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine();
        estatisticasString(texto);

    }

}
}
