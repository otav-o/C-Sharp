using System;
public class Aula021 {
public static void Main(string[] args) {
	string senha = "otavio123";
	string senhaInput;
	int tentativas = 0;
	do {
		Console.Clear(); // limpa até o que tinha antes da execução
		if (tentativas >= 5)
			goto bloqueado;  // poderia ter feito um procedimento também
		Console.Write("Insira a senha: ");
		senhaInput = Console.ReadLine();
		tentativas++;
		
	} while (senhaInput != senha);
	System.Console.WriteLine("Acesso autorizado. Número de tentativas: {0}.", tentativas);

	goto saida;	// gambiarra. Não achei um comando exit

	bloqueado:
		Console.WriteLine("Você errou a senha mais de 5 vezes! Tente novamente mais tarde.");
	saida:	// pelo visto não pode terminar com um label vazio
	Console.ReadKey();
}
} // funciona muito bem