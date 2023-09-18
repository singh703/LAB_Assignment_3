using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessPrivateField
{
    class MyClass
    {
        private int myPrivateField;

        public void SetPrivateFieldValue(int newValue)
        {
            myPrivateField = newValue;
        }

        public void DisplayPrivateFieldValue()
        {
            Console.WriteLine($"Private Field Value: {myPrivateField}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();

            myObject.SetPrivateFieldValue(42);
            myObject.DisplayPrivateFieldValue();
        }
    }
}
