using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AnotherAssembly")]

namespace _3_accessDiffAssembly
{
    internal class Class1
    {
        public class MyClass
        {
            internal int internalField = 42;
        }
    }
}
