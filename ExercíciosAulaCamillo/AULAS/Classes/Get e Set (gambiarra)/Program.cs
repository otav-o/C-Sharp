using System;
class Program {
    static void Main() {
        Atleta obj = new Atleta();
        obj.Nome = "Ana";
        obj.Peso = 60;
        obj.Altura = 1.7;

        Atleta[] atletas = new Atleta[3];

        Atleta obj;

        for (int i = 0; i < atletas.Length; i++) {
            
            atletas[i] = RetornarNovoAtleta();
        }

        Console.WriteLine("Atletas informados:");

        for (int i = 0; i < atletas.Length; i++) {
            Console.WriteLine("{0}, IMC: {1}", atletas[i].Nome, atletas[i].IMC)
        }

    }

    static Atleta RetornarNovoAtleta() {
        atletas[i] = new Atleta(); // é preciso inicializar antes de atribuir

        Console.Write("Nome: ");
        atletas[i].Nome = Console.ReadLine();

        Console.Write("Peso: ");
        atletas[i].Peso = Convert.ToDoubleConsole.ReadLine();

        Console.Write("Altura: ");
        atletas[i].Altura = Convert.ToDouble(Console.ReadLine());

        return obj;
    }
}
