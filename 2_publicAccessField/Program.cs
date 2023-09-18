using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_publicAccessField
{
    // Class in the same assembly
    class MyClassA
    {
        private int myPrivateField = 10;

        public int GetPrivateFieldValue()
        {
            return myPrivateField;
        }
    }

    // Another class in the same assembly
    class MyClassB
    {
        public void AccessPrivateField()
        {
            MyClassA instanceA = new MyClassA();
            int privateValue = instanceA.GetPrivateFieldValue();
            Console.WriteLine($"Accessed Private Field Value: {privateValue}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClassB instanceB = new MyClassB();
            instanceB.AccessPrivateField();
        }
    }
}
