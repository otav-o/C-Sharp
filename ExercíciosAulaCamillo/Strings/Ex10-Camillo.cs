using System;
class RespostaCamillo {
    static void Main() {

    }

    static void ImprimeEstatistica (string str) {

        int i, contVogais = 0, contConsoantes = 0, contOutros = 0;

        for (i = 0; i < str.Length; i++) {
            if (EhVogal(str[i])) contVogais++;
            else if (EhConsoante(str[i])) contConsoantes++;
            else contOutros++;
        }
    }

    static bool EhVogal (char c) {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
               c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';  
    }

    static bool EhConsoante(char c) {
        if (c >= 'b' && c <= 'z')
        return !EhVogal(c);
        else if (c >= 'B' && c <= 'Z')
        return !EhVogal(c);
        else 
        return false;

        /*if ((c >= 'b' && c <= 'z') || (c >= 'B' && c <= 'Z'))
        return !EhVogal(c);
        else if ()
        */
    }
}