/*5) Imagine que tenha sido realizada uma pesquisa com 6 pessoas a respeito de salário e idade. Crie uma classe Pessoa e faça um programa que leia os dados coletados e forneça a média salarial e a média de idades dos entrevistados.*/

using System;

class Pessoa {
    private double salario;
    private int idade;


    public double sal {
        get {
            return salario;
        } 

        set {
            if (value > 0) salario = value;
            else salario = 1000;
        }
    }

    public int idad {
        get {
            return idade;
        }

        set {
            if (value > 0) 
                idade = value;
            else   
                idade = 18;
        }
    }

    // não sei se é assim que se faz nem se o método é estático e fica na classe Pessoa (mas funciona)
    // já me falaram que não se faz rotina de impressão de dentro da classe
    public static void imprimeMedia(Pessoa[] p) { 
        double somaSalario = 0, somaIdade = 0;
        for (int i = 0; i < p.Length; i++) {
            somaSalario += p[i].salario;
            somaIdade += p[i].idade;
        }
        Console.WriteLine("Média salarial: R${0:2N}\nMédia de idade: {1} anos", somaSalario/p.Length, somaIdade/p.Length);
    }
}


class Ex05 {
    static void Main() {
        Console.Write("Quantas pessoas participaram da pesquisa? ");
        int n = Convert.ToInt32(Console.ReadLine());

        Pessoa [] pesquisa = new Pessoa[n];

        for (int i = 0; i < pesquisa.Length; i++) {
            Console.WriteLine("Pessoa {0}", i + 1);
            Console.Write("Insira a idade: ");
                pesquisa[i].idad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o salário");
                pesquisa[i].sal = Convert.ToDouble(Console.ReadLine());
        }

        Pessoa.imprimeMedia(pesquisa);

    }
} // deu errado!