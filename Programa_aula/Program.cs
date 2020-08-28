using System;

namespace Programa_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            String nome = Console.ReadLine();
            Console.Write("Digite sua idade! ");

            int idade = Convert.ToInt32(Console.ReadLine());
            //int idade = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Olá, " + nome + "!");
            Console.WriteLine("No próximo ano você terá " + (idade + 1) + " anos.");

            Console.WriteLine("Olá {0}!", nome);
            //Console.WriteLine("{1], no ano passado você tinha {0} anos.", idade - 1, nome);
            Console.WriteLine("{1}, no ano passado você tinha {0} anos.", nome, idade-1);
            
            
        }
    }
}
