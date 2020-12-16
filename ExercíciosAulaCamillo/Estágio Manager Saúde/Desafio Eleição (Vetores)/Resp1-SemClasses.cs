// Faça um programa que leia o número de candidatos e o número de eleitores para um sistema de votação. Esse programa deve permitir ao usuário informar o número de cada candidato (número para votação) e, em seguida, deve começar a solicitar o voto de cada eleitor. Ao término do programa, imprima o número de votos recebido por cada candidato.
using System;

class Eleicao
{
    public static void Main()
    {
        // Coletar a quantidade de candidatos e eleitores
        Console.Write("Digite a quantidade de candidatos: ");
        int qtdCandidatos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a quantidade de eleitores: ");
        int qtdEleitores = Convert.ToInt32(Console.ReadLine());

        int[] candidatos = new int[qtdCandidatos];

        // Popular o vetor com número dos candidatos
        leNumerosCandidatos (candidatos);

        // Realizar votação. Retorna um vetor com a quantidade de votos.
        int[] resultadoFinal = colherVotos(candidatos, qtdEleitores);

        imprimeResultado (resultadoFinal);
    }

    static void leNumerosCandidatos(int[] vet)
    {
        Console.WriteLine("~~~ Cadastro dos candidatos ~~~");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write("Digite o número do {0}° candidato: ", i + 1);
            vet[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static int[] colherVotos(int[] candidatos, int qtdEleitores)
    {
        Console.WriteLine("---- A votação foi iniciada ----");
        int voto = 0;
        int[] resultadoFinal = new int[candidatos.Length];
        for (int i = 0; i < qtdEleitores; i++)
        {
            Console.WriteLine("Votando eleitor {0}/{1}", i + 1, qtdEleitores);
            Console.Write("  Digite o número do candidato: ");
            voto = Convert.ToInt32(Console.ReadLine());

            registraVoto (candidatos, resultadoFinal, voto);

            Console.WriteLine("Obrigado por votar!");
        }

        return resultadoFinal;
    }

    static void registraVoto(int[] candidatos, int[] resultadoFinal, int voto)
    {
        for (int i = 0; i < candidatos.Length; i++)
        {
            if (voto == candidatos[i]) resultadoFinal[i] += 1;
        }
    }

    static void imprimeResultado(int[] resultado)
    {
        for (int i = 0; i < resultado.Length; i++)
        {
            Console
                .WriteLine("O candidato {0} recebeu {1} votos.",
                i + 1,
                resultado[i]);
        }
    }
} // funciona perfeitamente, mas não gostei!
