/*4) Faça um programa (método principal) para leitura, via teclado, dos dados de um contato de telefone. Os dados a serem guardados na classe Contato são os seguintes: nome, endereço (logradouro, número, complemento, bairro, cidade, UF), telefone e e-mail. Ao final, imprima estas informações na tela.*/

using System;

class Contato {
    public string nome, telefone, email;
    public Endereco endereco = new Endereco(); // isso está certo?
    
}

class Endereco {
    public string logradouro, bairro, cidade, uf;
    public int numero, complemento;
}


class Ex04 {
    static void Main() {
        Contato c1 = new Contato();
        c1.nome = "Miriã";
        c1.telefone = "32 99999-9999";
        c1.email = "email@outlook.com";
        c1.endereco.bairro = "Centro";
        c1.endereco.cidade = "Rio de Janeiro";
        c1.endereco.uf = "RJ";
        c1.endereco.logradouro = "Rua das Flores";
        c1.endereco.numero = 350;
        c1.endereco.complemento = 150;


        Console.WriteLine("Nome: {0}\nTelefone: {1}\nE-mail: {2}\nEndereço:\n  Rua: {3}\n  Numero: {4}\n  Complemento: {5}\n  Bairro: {6}\n  Cidade: {7}\n  Estado: {8}", c1.nome, c1.telefone, c1.email, c1.endereco.logradouro, c1.endereco.numero, c1.endereco.complemento, c1.endereco.bairro, c1.endereco.cidade, c1.endereco.uf);
    }
} // feito. Conferir se é para instanciar um objeto Endereco dentro da classe contato.