/* leia o nome e nota de 5 alunos, armazenando-os em 2 vetores diferentes. Calcule a média das notas*/

using System;
class Camillo {
    static void Main() {
        Console.WriteLine("Quantos alunos você deseja inserir? ");
        int n = Convert.ToInt32(Console.ReadLine());
        string [] alunos = new string(n);
        double [] notas = new double (n);

        for (int i = 0; i < n; i++) {
            Console.Write("Nome do aluno [{0}/{1}]", i, n);
            alunos[i] = Console.ReadLine();
            Console.Write("Nota do aluno: ");
            notas[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        for (int i = 0; i < n; i++) {
            soma += 
        }
    }
}