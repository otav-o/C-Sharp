/*QUESTÃO 02 (3 pontos): Faça um programa que leia um vetor de 5 contatos. Cada contato possui um nome (string) e um 
e-mail (string). Após a leitura do vetor, solicite ao usuário que informe o nome de um contato. O programa deve 
imprimir o e-mail do contato cujo nome seja igual ao informado pelo usuário. Caso não exista contato com o mesmo nome 
informado pelo usuário, o sistema deve imprimir “Contato não localizado”. Esse programa deve representar o conceito 
“Contato” utilizando uma classe. Na resposta, cole todo o código da classe Program e todo o código da classe Contato.*/

using System;

class Contato {
    private string nome;
    private string email;

    public static Contato[] CriarContatos(int quantidade) {
        Contato[] vet = new Contato[quantidade];
        for (int i = 0; i < quantidade; i++) {
            vet[i] = new Contato();
            vet[i].PreencheContato();
        }
        return vet;
    }

    public static string AcharEmail(Contato[] vet, string nome) {
        for (int i = 0; i < vet.Length; i++) {
            if (vet[i].nome == nome)
                return vet[i].email;
        }
        return "NÃO ENCONTRADO";
    }

    private void PreencheContato() {
        Console.Write("-=-=-=-\nDigite o nome: ");
            this.nome = Console.ReadLine();
        Console.Write("Digtite o e-mail: ");
            this.email = Console.ReadLine();
    }
    
}

/*class ListaContatos:Contato {
    // depois tentar com indexador
}*/


class Questao2 {
    static void Main() {

        Contato[] lista = Contato.CriarContatos(5);

        Console.WriteLine("");
        Console.Write("Nome a ser pesquisado: ");
        string nome = Console.ReadLine();

        string email = Contato.AcharEmail(lista, nome); 

        Console.Write("E-mail do(a) {0}: {1}", nome, email);
    }
} // feito

