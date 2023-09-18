using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_accessProtectedMembers
{
    class MyBaseClass
    {
        protected int protectedField;
        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        public void AccessProtectedMembers()
        {
            protectedField = 42; // Accessing protected field from the derived class
            ProtectedMethod();   // Accessing protected method from the derived class
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedInstance = new MyDerivedClass();
            derivedInstance.AccessProtectedMembers();
        }
    }
}
