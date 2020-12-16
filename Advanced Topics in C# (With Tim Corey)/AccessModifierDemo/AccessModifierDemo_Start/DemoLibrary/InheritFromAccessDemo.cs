using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class InheritFromAccessDemo : AccessDemo
    {
        public void Test()
        {
            ProtectedDemo();
            InternalDemo();
            PublicDemo();
            // PrivateDemo();

            PrivateProtectedDemo();
                // that inherit AND is in the same assembly

            ProtectedInternalDemo();
                // same assembly and inherit (also works if does not inherit)


           
        }
 
    }
}
