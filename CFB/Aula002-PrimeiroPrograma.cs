//06:20 23/09/2020
using System;
namespace Aula02 {
class Program {
	static void Main(string[] args)
	{
		Console.WriteLine("Otávio");
		if (args.GetLength(0) > 0) {
			Console.Write(args.GetValue(0));
		}	//argumentos de entrada
	}
}}	//padrão dotnet