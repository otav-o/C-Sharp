/*Faça um programa utilizando a linguagem C# que leia, de forma intercalada, cada uma das jogadas do primeiro e do segundo jogador de um jogo da velha. As jogadas do primeiro jogador devem ser representadas em uma matriz de caracteres com o caractere ‘X’. As jogadas do segundo jogador devem ser representadas com ‘O’. Ao final do jogo, o programa deve indicar o vencedor ou indicar se “deu velha” no caso de empate.*/

using System;

class APS2 {
    static void Main() {
        char [,] jogo = new char[3,3]; // cria a matriz de 9 casas
        int linha, coluna, jo = 0; // jo define se é jogador 1 ou 2
        char resp = ' ';    // inicialização somente
        for (int i = 1; i < 10; i++) {
            if (i % 2 != 0) { // jogador 1: contador ímpar.
                jo = 1;
                resp = 'x';
            } else {
                jo = 2;
                resp = 'o';
            }

            Console.WriteLine("--- Vez do jogador {0} ({2}) ----\n{1}° lance", jo, i, resp);
            Console.Write(" Digite a linha: ");
            linha = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Digite a coluna: ");
            coluna = Convert.ToInt32(Console.ReadLine());

            if (!jogar(jogo, linha, coluna, resp)) i--; // se jogar retornar falso, é porque a casa já está ocupada
            else if (checarVitoria(jogo)) break; // se houver vitória, acaba o jogo
            
        }
        
    }

    static bool jogar(char[,] jogo, int linha, int coluna, char jog) {
        if (jogo[linha, coluna] != 'x' && jogo[linha, coluna] != 'o') {
            jogo[linha, coluna] = jog;
            imprimirJogo(jogo);
            checarVitoria(jogo);
            return true;
        } else {
            Console.WriteLine("Erro. Já jogaram aí. Tente de novo.");
            return false;
        }
       
    }

    static void imprimirJogo(char[,] jogo) {
        for (int i = 0; i < jogo.GetLength(0); i++) {
            for (int j = 0; j < jogo.GetLength(1); j++) {
                Console.Write(" | ");
                Console.Write(jogo[i,j]);
            }
            Console.Write(" |\n");
        }

    }

    static bool checarVitoria(char[,] jogo) {
        if (checarLinhaEColuna(jogo) == 1) {
            Console.Write("FIM DE JOGO. Jogador 1 ganhou!");
            return true;
        } else if (checarLinhaEColuna(jogo) == 2) {
            Console.Write("FIM DE JOGO. Jogador 2 ganhou!");
            return true;
        } else {
            return false;
        }
    }

    static int checarLinhaEColuna(char[,] jogo) {
        int linha = 0, coluna = 0;
        for (int i = 0; i < jogo.GetLength(0); i++) {
            for (int j = 0; j < jogo.GetLength(1); j++) {

                if (jogo[i, j] == 'x') 
                    linha++; 
                else if (jogo[i, j] == 'o')
                    linha--;

                if (jogo[j, i] == 'x')
                    coluna++;
                else if (jogo[j, i] == 'o')
                    coluna--;

                if (linha == 3 || coluna == 3) return 1;
                else if (linha == -3  || coluna == -3) return 2;
            }
            linha = coluna = 0;
        }

        return 0;
    }
    
}