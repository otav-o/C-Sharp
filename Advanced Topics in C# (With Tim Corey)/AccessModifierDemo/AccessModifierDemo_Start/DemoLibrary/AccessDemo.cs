using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {
        private void Demo()
        {
            PrivateDemo();
        }
        private void PrivateDemo()
        {
            // only accessible in the area it was declared (curly braces). Only the class can call it
        }

        private protected void PrivateProtectedDemo()
        {
            // accessible to classes that inherit AND are in the same assembly
        }

        protected void ProtectedDemo()
        {
            // like private, but visible to inheriting classes
        }

        protected internal void ProtectedInternalDemo()
        {
            // visible to: all classes that inherit OR are in same assembly
            // protected to all 
        }

        internal void InternalDemo()
        {
            // Instead of the scope being the curly braces that the method/property is, the scope is the entire object
            // each project creates a assembly (.exe, .dll, etc. files)
            // not visible outside the assembly
            // anywhere inside the assembly

        }

        public void PublicDemo()
        {
            // accessible everywhere
        }
    }
}
