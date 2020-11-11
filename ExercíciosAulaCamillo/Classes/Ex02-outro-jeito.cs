/*agora fazendo com get e set padrões*/

using System;

class Pessoa {
    private double altura, peso;

    public double alt {
        set {
            if (value > 0) altura = value;
            else altura = 0;
        }

        get {
            return altura;
        }
    }

    public double pes {
        get {
            return peso;
        }

        set {
            if (value < 0) peso = 0;
            else peso = value;
        }
    }
}

class Ex02 {
    static void Main() {
        Pessoa p2 = new Pessoa();
        Console.Write("Digite o peso: ");
        p2.pes = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura: ");
        p2.alt = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Peso: {0}\nAltura: {1}", p2.pes, p2.alt);

    }
} // feito. Lembrar do value