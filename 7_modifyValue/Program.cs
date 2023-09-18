using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_modifyValue
{
    class MyClass
    {
        private string myProperty;

        public void SetMyProperty(string value)
        {
            myProperty = value;
        }

        public void DisplayMyProperty()
        {
            Console.WriteLine("MyProperty value: " + myProperty);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();
            myObject.SetMyProperty("Hello, Private Property!");
            myObject.DisplayMyProperty();
        }
    }
}
