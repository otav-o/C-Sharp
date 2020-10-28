using System;
using System.Text;

class aula {
    static void oi() {
        string s1 = "Teste";
        char c1 = ' ';
        string s2 = "isso";

        StringBuilder sb = new StringBuilder();

        sb.Append(s1); // adiciona s1 ao objeto sb da classe stringbuilder
        sb.Append(c1);
        sb.Append(s2);

        string mensagem = sb.ToString(); // concatena tudo e retorna uma string

        Console.WriteLine(mensagem);
    }

    static void ola() {
        string mensagem;
        char caractere;
        StringBuilder otavio = new StringBuilder();

        Console.WriteLine("Informe um caractere por vez ou espaço para sair: ");
        caractere = Convert.ToChar(Console.ReadLine());
        while (caractere != ' ') {
            otavio.Append(caractere);
            caractere = Convert.ToChar(Console.ReadLine());

        }
        mensagem = otavio.ToString();
        Console.WriteLine(mensagem);
    }

    static void Main() {
        string s1 = "Algoritmos";
        string s2 = "Algo" + "ritmos";

        if (s1 == s2) Console.WriteLine("s1 é igual a s2 (usei ==)");
        if (s1.Equals(s2)) Console.WriteLine("s1 é igual a s2 (usei string1.Equals(string2))");
        }

    
}