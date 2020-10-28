using System;

class Concatenar {
    static void Main() {
        string palavra = "";
        char caractere;

        Console.Write("Informe um caractere por vez e um espaço para finalizar: ");
        caractere = Convert.ToChar(Console.ReadLine());

        while (caractere != ' ') {
            palavra = palavra + caractere;
            caractere = Convert.ToChar(Console.ReadLine());
        }


        Console.WriteLine("Palavra informada: " + palavra);
    }
}