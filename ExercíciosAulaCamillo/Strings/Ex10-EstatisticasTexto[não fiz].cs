/*10) Fazer um procedimento para receber uma string do usuário e imprimir uma estatística dos caracteres digitados. Isto é,  imprimir o número de vogais, consoantes e outros caracteres.
Seria legal refazer isso daqui usando classes e etc. Futuramente: fazer uma função eVogal(char c) que retorne um booleano*/

// enjoei 
using System;
class Ex10 {

    static int numeroVogais(string s) {
        for (int i = 0; i < s.Length; i++) 
    }
    static void estatisticasString(String s) {
        Console.WriteLine("-=-=-=\nSeu texto tem: {0} vogais, {1} consoantes, {2} demais caracteres, totalizando {3}.", numeroVogais(s), numeroConsoantes(s), outrosCaracteres(s), s.Length);
    }
    static void Main() {

    }
}
