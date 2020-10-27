/* leia o nome e nota de 5 alunos, armazenando-os em 2 vetores diferentes. Calcule a média das notas*/
/* imprimir o nome e a nota dos alunos cuja nota seja maior que a média */
/* receba uma letra e liste somente os alunos com essa inicial */

using System;
class Camillo {
    static void Main() {
        Console.Write("Quantos alunos você deseja inserir? ");
        int n = Convert.ToInt32(Console.ReadLine());
        string [] alunos = new string[n];
        double [] notas = new double [n];

        for (int i = 0; i < n; i++) {
            Console.Write("Nome do aluno [{0}/{1}]: ", i + 1, n);
            alunos[i] = Console.ReadLine();
            Console.Write("Nota do aluno: ");
            notas[i] = Convert.ToInt32(Console.ReadLine());
        }
        double soma = 0;
        for (int i = 0; i < n; i++) {
            soma += notas[i];
        }
        double media = soma/n;
        Console.WriteLine("A média das notas é {0}.", media);

        Console.WriteLine("Os alunos acima da média são:");
        for (int i = 0; i < n; i++) {
            if (notas[i] > media) {
                Console.WriteLine("{0} com {1} pontos", alunos[i], notas[i]);
            }
        }

        Console.Write("Digite uma letra: ");
    
        char letra = Convert.ToChar(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            if (alunos[i][0] == letra) {
                Console.WriteLine("{0} tem essa inicial!", alunos[i]);
            }
        }
    }
} // feito. Mas tá uma zona, muito mal escrito. vou refazer com funções (e depois classes, quando aprender.)