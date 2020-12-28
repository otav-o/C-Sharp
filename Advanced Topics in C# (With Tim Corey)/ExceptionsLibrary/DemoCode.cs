using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{
    public class DemoCode
    {
        public int GrandparentMethod(int position)
        {
            int output = 0;

            Console.WriteLine("Open Database Connection");

            try
            {
                output = ParentMethod(position);
            }
            catch (Exception ex)
            {
                // throw; // catch the exception and immediately pass it up the methods chain
                // it's not in the UI layer (doesn't know if it is a console app or a form) so it cannot display messages.

                // not equivalent to 'throw ex' - it rewrites the stack and gives you wrong infomation!
                // throw new Exception("I blew up"); 

                throw; // new ArgumentException("You passed in bad data", ex);
            }
            finally // runs with exception or not before passing exception
            {
                Console.WriteLine("Close Database Connection");
                // don't put code here that might an exception
            }
            

            return output;

        }
        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }
        public int GetNumber(int position)
        {
            int output = 0;
            //try
            //{
                int[] numbers = new int[] { 1, 4, 7, 2 };
                output = numbers[position];
            //}
            //catch (Exception ex) // put the exception into ex
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace); // says where the problem is (offending line)

            //}

            return output;
        }
    }
}
