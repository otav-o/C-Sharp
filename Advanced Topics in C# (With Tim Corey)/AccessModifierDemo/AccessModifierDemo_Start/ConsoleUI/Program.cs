using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessDemo demo = new AccessDemo();
            // demo.PrivateDemo();
                // you can not call a private method from a different class

            // demo.InternalDemo();
                // you can not call a internal method from a different assembly

            demo.PublicDemo();

            // demo.ProtectedInternalDemo();
                // outside the assembly and does not inherit
        }

        private static void SayHello()
        {
            Console.WriteLine("Hello user");
        }
    }
}
