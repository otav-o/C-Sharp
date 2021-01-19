using System;

namespace Delegates
{
    class Program
    {
        public delegate void TestDelegate(); // define um tipo de delegate
        public delegate bool TestBoolDelegate(int i);

        private TestDelegate testDelegateFunction;
        private TestBoolDelegate testBoolDelegateFunction;

        private Action testAction; // na maioria dos casos é melhor usar Action/Func no lugar de Delegates
        private Action<int, float> testIntFloatAction;

        private Func<bool> noParametersFunc;
        private Func<int, bool> testIntBoolFunc;

            // action: void; func: retorna valor - é sempre o último tipo definido entre < >
        static void Main(string[] args)
        {
            var p1 = new Program();
            p1.testDelegateFunction += delegate () { Console.WriteLine("Anonymous method"); };
            p1.testDelegateFunction += () => { Console.WriteLine("Lambda expression"); };

            p1.testDelegateFunction(); // Não é possível remover uma função anônima ou Lambda de um delegate, já que não há referência a ela.

            p1.testIntFloatAction = (int i, float f) => { Console.WriteLine("Test int float action!"); };

            p1.noParametersFunc = () => false;
            p1.testIntBoolFunc = (int i) => i < 5;

            Console.WriteLine(p1.noParametersFunc());
            Console.WriteLine(p1.testIntBoolFunc(3));


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
