/*2) Defina uma classe para representar o peso e a altura de uma pessoa. Crie um programa que pergunte ao usuário o seu peso e a sua altura, atribuindo-os aos respectivos atributos de um objeto da classe criada. Imprima os atributos da classe criada.*/

using System;

class Pessoa {
    private double peso, altura;

    public void setPeso(double peso) {
        if (peso > 0)
            this.peso = peso;
        else
            this.peso = 0;
    }
    public double getPeso() {
        return peso;
    }

    public void setAltura(double altura) {
        if (altura < 0) this.altura = 0; else
        this.altura = altura;
    }
    public double getAltura() {
        return altura;
    }
}

class Ex02 {
    static void Main() {
        Pessoa p1 = new Pessoa();
        Console.Write("Qual o peso? ");
        p1.setPeso(Convert.ToDouble(Console.ReadLine()));

        Console.Write("Qual a altura? ");
        p1.setAltura(Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine("A altura é {0}m e, o peso, {0}kg", p1.getAltura(), p1.getPeso());

    }   
} // feito. Vou refazer com os métodos get e set nativos do C#