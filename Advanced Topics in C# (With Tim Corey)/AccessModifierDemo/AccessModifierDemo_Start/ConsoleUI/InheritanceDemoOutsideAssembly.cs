using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class InheritanceDemoOutsideAssembly : AccessDemo
    {
        private void Demo()
        {
            ProtectedDemo(); // ok, because there is inheritance

            // PrivateProtectedDemo();
                // does not work
                // you can only access private protected method inside the same assembly

            ProtectedInternalDemo();
                // outside the assembly but inherits (works)


        }
    }
}
