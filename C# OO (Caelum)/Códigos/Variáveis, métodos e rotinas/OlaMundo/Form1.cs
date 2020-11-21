using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeRicardo = 55;
            int idadeRafael = 16;
            int idadeOtavio = 19;
            double media = (idadeOtavio + idadeRafael + idadeRicardo)/ 3;
            MessageBox.Show("A média das idades é: " + media);

            Conta c1 = new Conta();
            c1.Saldo = 1000;
            Conta c2 = new Conta();
            c2.Saldo = 2000;

            c2.Transfere(c1, 500);

            MessageBox.Show("c1 = R$" + c1.Saldo);
            MessageBox.Show("c2 = R$" + c2.Saldo);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            // int pi = 3.14; // não compila
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado: " + piQuebrado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 4;
            int c = 0;

            double delta = Math.Pow(b, 2) - 4 * a * c;
            double a1 = -b + Math.Sqrt(delta) / 2 * a; // lembrar que não existe raiz quadrada de número negativo
            double a2 = -b - Math.Sqrt(delta) / 2 * a;

            MessageBox.Show("Delta: " + delta + "\n" +
                "a1: " + a1 + "\n" +
                "a2: " + a2);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool brasileiro = true;
            int idade = 15;

            if (brasileiro && (idade >= 16)) MessageBox.Show("Está apta a votar");
            else MessageBox.Show("Não pode votar");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*Crie um programa que tenha uma variável double valorDaNotaFiscal e, de acordo com esse
valor, o imposto deve ser calculado. As regras de cálculo são:
Se o valor for menor ou igual a 999, o imposto deve ser de 2%
Se o valor estiver entre 1000 e 2999, o imposto deve ser de 2.5%
Se o valor estiver entre 3000 e 6999, o imposto deve ser de 2.8%
Se for maior ou igual a 7000, o imposto deve ser de 3%
Imprima o imposto em um MessageBox.*/

            double valorDaNotaFiscal = 5000;
            double aliquota = 0;

            if (valorDaNotaFiscal <= 999) aliquota = 0.02;
            else if (valorDaNotaFiscal <= 2999) aliquota = 0.025;
            else if (valorDaNotaFiscal <= 6999) aliquota = 0.028;
            else aliquota = 0.03;

            MessageBox.Show("Valor da nota: " + valorDaNotaFiscal +
                "\nValor do imposto: " + valorDaNotaFiscal * aliquota +
                "\nValor final: " + valorDaNotaFiscal * (1 - aliquota));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int valor = 15;
            string mensagem = "";
            mensagem = valor > 10 ? "Maior que dez" : "Menor que 10";
            MessageBox.Show(mensagem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Faça um programa em C# que imprima a soma dos números de 1 até 1000.
            int soma = 0;
            for (int i = 1; i < 1001; i++)
            {
                soma += i;
            }
            MessageBox.Show("A soma dá " + soma);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Faça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.
            int i = 0;
            while (i < 100)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show(i + " ");
                }
                i++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /* Escreva um programa em C# que some todos os números de 1 a 100, pulando os
            múltiplos de 3. O programa deve imprimir o resultado final em um MessageBox.*/
           

            int soma = 0;
            for (int i = 0; i < 100; i++)
            {
                if (!(i % 3 == 0))
                {
                    soma += i;
                }
            }
            MessageBox.Show("Soma = " + soma);
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*Escreva um programa em C# que imprime todos os números que são divisíveis por 3 ou
por 4 entre 0 e 30.*/

            for (int i = 0; i < 30; i++)
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    MessageBox.Show("" + i);
                }
            }

        }


        private void button11_Click(object sender, EventArgs e)
        {
            /*Faça um programa em C# que imprima os fatoriais de 1 a 10.*/
            for (int i = 1; i <= 10; i++)
            {
                int fatorial = 1;
                for (int n = i; n > 1; n-=1)
                {
                    fatorial *= n;
                }

                MessageBox.Show(fatorial + "");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*Faça um programa em C# que imprima os primeiros números da série de Fibonacci até
passar de 100. A série de Fibonacci é a seguinte: 0, 1, 1, 2, 3, 5, 8, 13, 21 etc... Para calculá-la, o
primeiro elemento vale 0, o segundo vale 1, daí por diante, o n-ésimo elemento vale o (n-1)-ésimo
elemento somado ao (n-2)-ésimo elemento (ex: 8 = 5 + 3).*/

            /* 0
             * 1
             * 1 + 0 = 1
             * 1 + 1 = 2
             * 1 + 2 = 3
             * 3 + 2 = 5
             * 5 + 3 = 8
             * 8 + 5 = 13 */

            long atual = 0;
            long ultimo = 1;
            long penultimo = 0; // mesmo com o long ele buga nos números finais

            for (int i = 2; i < 110; i++)
            {
                atual = ultimo + penultimo;
                MessageBox.Show(atual + "");
                penultimo = ultimo;
                ultimo = atual;
            }
           

        }

        private void button13_Click(object sender, EventArgs e)
        {
            /*Faça um programa que imprima a seguinte tabela, usando for s encadeados:
1
2 4
3 6 9
4 8 12 16
n n*2 n*3 .... n*n
            */
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Conta contaVictor = new Conta();
            contaVictor.Titular = "Victor";
            contaVictor.Numero = 1;
            contaVictor.Saldo = 1000.00;

            MessageBox.Show(contaVictor.Titular + " - saldo: R$" + contaVictor.Saldo);


            Conta contaHelena = new Conta
            {
                Titular = "Helena",
                Numero = 2,
                Saldo = 1500
            }; // VS que sugeriu isso

            MessageBox.Show(contaHelena.Titular + " - saldo: R$" + contaHelena.Saldo);

            contaHelena.Saca(200);
            contaVictor.Deposita(500);

            MessageBox.Show(contaVictor.Titular + " - saldo: R$" + contaVictor.Saldo);
            MessageBox.Show(contaHelena.Titular + " - saldo: R$" + contaHelena.Saldo);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.Numero = 1;
            mauricio.Titular = "Mauricio";
            mauricio.Saldo = 100;

            Conta mauricio2 = new Conta();
            mauricio2.Numero = 1;
            mauricio2.Titular = "Mauricio";
            mauricio2.Saldo = 100;

            if (mauricio == mauricio2) MessageBox.Show("São contas iguais");
            else MessageBox.Show("São diferentes"); // linha que é executada
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta(); // mauricio aponta a um objeto
            mauricio.Saldo = 2000;

            Conta copia = mauricio; // copia passa a apontar para esse objeto (não cria outro)
            copia.Saldo = 3000;

            MessageBox.Show("Mauricio = " + mauricio.Saldo); // são o mesmo objeto, os dois imprimem 3000
            MessageBox.Show("Copia = " + copia.Saldo); // duas variáveis, um objeto
        }
    }
}
