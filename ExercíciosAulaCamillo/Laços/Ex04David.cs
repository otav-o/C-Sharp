using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            double divida, aplicacao;
            int mes;
            mes = 1; 
            
            aplicacao = 1500;
            divida = 10000;

            
            aplicacao = aplicacao * mes;
            
            divida = divida * mes;
                       

            while (divida > aplicacao){


            if (divida > aplicacao) 
            
            {
                
               aplicacao = aplicacao + (aplicacao * 0.04);
               divida = divida + (divida * 0.025);
                
               
                
                

                mes ++;
                
                Console.WriteLine("Aplicação em {1} meses:{0:N2}", aplicacao, mes);
            
                Console.WriteLine("Divida em {1} meses:{0:N2}", divida, mes);

            }

            }
            
            
        }
    }
}