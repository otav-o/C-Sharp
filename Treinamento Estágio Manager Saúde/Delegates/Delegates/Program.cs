using System;

namespace Delegates
{
    class Program
    {
        public delegate void TestDelegate(); // define um tipo de delegate
        public delegate bool TestBoolDelegate(int i);

        private TestDelegate testDelegateFunction;
        private TestBoolDelegate testBoolDelegateFunction;
        static void Main(string[] args)
        {
            var p1 = new Program();
            p1.testDelegateFunction = delegate () { Console.WriteLine("Anonymous method"); };
            // método anônimo deve seguir a assinatura do delegate (inclusive os parâmetros)

            p1.testDelegateFunction();

            p1.testDelegateFunction = () => { Console.WriteLine("Lambda expression"); };

            p1.testDelegateFunction();

            p1.testBoolDelegateFunction = (int i) => { return i < 5; };
            p1.testBoolDelegateFunction = (int i) => i < 5; 
                // modo + compacto se a função tiver apenas uma linha

            Console.WriteLine(p1.testBoolDelegateFunction(4));
        }
        private void MyTestDelegateFunction() // declação de função que condiz com o delegate
        {
            Console.WriteLine("Testing MyTestDelegateFunction");
        }

        private void MySecondTestDelegateFunction()
        {
            Console.WriteLine("MySecondTestDelegateFunction");
        }

        private bool MyTestBoolDelegateFunction(int i)
        {
            return i < 5;
        }
    }
}
