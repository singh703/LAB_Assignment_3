using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_accessDiffAssembly.Class1;
using _3_accessDiffAssembly;

namespace _3_accessDiffAssembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myInstance = new MyClass();
            int value = myInstance.internalField;
        }
    }
}
