using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_deriveAnotherClass
{
    class BaseClass
    {
        public string MyProperty { get; set; }
    }

    class DerivedClass : BaseClass
    {
        public void DisplayProperty()
        {
            Console.WriteLine("Property value from DerivedClass: " + MyProperty);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derived = new DerivedClass();
            derived.MyProperty = "Hello, Property!";
            derived.DisplayProperty();
        }
    }
}
