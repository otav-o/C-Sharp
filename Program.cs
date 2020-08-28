using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double salario, mesada, total;
        
            Console.Write("Digite seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua mesada: ");
            mesada = Convert.ToDouble(Console.ReadLine());
            total = (double)salario + (double)mesada;
            Console.WriteLine("{1} + {0} = {2}", salario, mesada, total);


            
        }

    }
}
