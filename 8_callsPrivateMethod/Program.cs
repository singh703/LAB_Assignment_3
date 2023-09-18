using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_callsPrivateMethod
{
    class MyClass
    {
        public void PublicMethod()
        {
            Console.WriteLine("Calling public method...");
            PrivateMethod();
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private method called.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();
            myObject.PublicMethod();
        }
    }
}
