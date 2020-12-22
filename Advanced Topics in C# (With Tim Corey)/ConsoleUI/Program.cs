using ExceptionsLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoCode demo = new DemoCode();

            try
            {
                int result = demo.GrandparentMethod(4);
                Console.WriteLine($"The value at the given position is {result}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            

            Console.ReadLine();
        }
    }
}
