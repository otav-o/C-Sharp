using System;
class Program {
    static void Main() {
        char dMin = 'd';
        char dMai = Convert.ToChar(dMin - 'a' + 'A'); // olhar a tabela. Distância desse caractere até a minúscula e somar à maiúscula.
        Console.WriteLine(dMai);
        Console.WriteLine("oi" + "oi");
        Console.WriteLine('o' + 'o');
    }




    static char ConverterParaMaiusculo(char c) {
        if (c >= 'a' && c <= 'z') {
            return Convert.ToChar(c - 'a' + 'A');
        } else {
            return c;
        }
    }

    static char ConverterParaMinusculo(char c) {
        if (c >= 'A' && c <= 'Z') { // se estiver entre as maiúsculas
            return Convert.ToChar(c - 'A' + 'a'); //
        } else {
            return c;
        }
    }
}

"oi"