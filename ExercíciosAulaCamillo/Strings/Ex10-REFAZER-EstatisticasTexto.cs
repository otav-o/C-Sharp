/*10) Fazer um procedimento para receber uma string do usuário e imprimir uma estatística dos caracteres digitados. Isto é,  imprimir o número de vogais, consoantes e outros caracteres.
Seria legal refazer isso daqui usando classes e etc!!*/

using System;

namespace oi { // criei um namespace para usar no exercício 11
public class Ex10 {

    static bool ehLetra(char l) {
        if (l >= 'a' && l <= 'z' || l >= 'A' && l <= 'Z') return true; // atenção
        else return false;
    }
    static bool ehVogal(char l) {
        if (ehLetra(l)) {
            l = (l >= 'a' ? l : Convert.ToChar(l - 'A' + 'a'));
            switch(l) {
                    case 'a': case 'e': case 'i': case 'o': case 'u': return true; default: break;
            }
            return false;
        } else {
            return false;
        }
    }

    static bool ehConsoante(char l) {
        if (ehLetra(l) && !ehVogal(l)) return true;
        else return false;
    }

// cálculos
    static int numeroVogais(string s) {
        int num = 0;
        for (int i = 0; i < s.Length; i++) {
            if (ehVogal(s[i])) num++;
        } 
        return num;
    }

 
    static int numeroConsoantes(string s) {
        int num = 0;
        for (int i = 0; i < s.Length; i++) {
            if (ehLetra(s[i]) && ehConsoante(s[i])) // não precisava checar se é letra
                num ++;
        }
        return num;
    }

    static int outrosCaracteres(string s) {
        int num = 0;
        for (int i = 0; i < s.Length; i++) {
            if (!ehLetra(s[i])) num++;
        }
        return num;
    }

    public static void estatisticasString(String s) {
        Console.WriteLine("-=-=-=\nSeu texto tem: {0} vogais, {1} consoantes, {2} demais caracteres, totalizando {3}.", numeroVogais(s), numeroConsoantes(s), outrosCaracteres(s), s.Length);
    }
    static void Main() {
        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine();

        estatisticasString(texto);
    }
} // feito. Funiona perfeitamente. É legal testar com o alfabeto inteiro abcdefghijklmnopqrstuvwxyz

}