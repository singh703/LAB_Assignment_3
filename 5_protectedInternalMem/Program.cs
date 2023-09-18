using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace _5_protectedInternalMem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myInstance = new MyClass();
            int value = myInstance.protectedInternalField; // This works since protectedInternalField is protected internal
            Console.WriteLine($"Value of protected internal field: {value}");
        }
    }
}
