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
            p1.testDelegateFunction = p1.MyTestDelegateFunction;
            // no fundo é isso que acontece: testDelegateFunction = new TestDelegate(MyTestDelegateFunction);

            p1.testDelegateFunction();

            p1.testBoolDelegateFunction = p1.MyTestBoolDelegateFunction;
            Console.WriteLine(p1.testBoolDelegateFunction(10));
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
