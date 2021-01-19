using System;

namespace Delegates
{
    class Program
    {
        public delegate void TestDelegate(); // define um tipo de delegate
        private TestDelegate testDelegateFunction;
        static void Main(string[] args)
        {
            var p1 = new Program();
            p1.testDelegateFunction = p1.MyTestDelegateFunction;
            // atribui a função ao delegate. Ela fica guardada lá e pode ser acessada pelo nome adicionado de parâmetros
            p1.testDelegateFunction();
        }
        private void MyTestDelegateFunction() // declação de função que condiz com o delegate
        {
            Console.WriteLine("Testing MyTestDelegateFunction");
        }
    }
}
