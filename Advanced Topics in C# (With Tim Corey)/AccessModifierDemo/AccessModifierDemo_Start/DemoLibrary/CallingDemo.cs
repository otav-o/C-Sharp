using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CallingDemo
    {
        private void MakeDemoCalls()
        {
            AccessDemo demo = new AccessDemo();

            // demo.PrivateDemo();
                // you can not access a private method/property/variable from outide the class (at least directly)

            demo.InternalDemo();
            // it is possible because it's the same assembly (visibility internal)
            // can I consider assembly = namespace?

            demo.PublicDemo();

            demo.ProtectedInternalDemo();
                // same assembly but does not inherit

        }
    }
}
