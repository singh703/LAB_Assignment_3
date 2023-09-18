using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_protectedMethod
{
    class BaseClass
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method called.");
        }
    }

    class DerivedClass : BaseClass
    {
        public void AccessProtectedMethod()
        {
            ProtectedMethod(); // Accessing protected method from the base class
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedObject = new DerivedClass();
            derivedObject.AccessProtectedMethod();
        }
    }
}
