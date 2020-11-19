using System;

class Program {
    static void Main() {
        decimal numeroGrande = 10;
        double numeroPequeno = 25;

        // o tipo decimal ocupa mais espaço que o double, razão pela qual pode haver perda de se convertido em double. O compilador C# recusa a atribuição, mas pode-se força-la usando o type cast
        numeroPequeno = (double) numeroGrande;
        Console.WriteLine(numeroGrande + " oi " + numeroPequeno);


        short valorPequeno = 100;
        long valorGrande = 25;

        valorGrande = valorPequeno; // não precisa do cast pois long > short

        Console.WriteLine(valorGrande);
    }
}