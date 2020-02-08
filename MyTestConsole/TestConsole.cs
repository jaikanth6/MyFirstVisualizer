using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstVisualizer;

namespace MyTestConsole
{
    class TestConsole
    {
        static void Main(string[] args)
        {
            String myString = "Hello, World";
            DebuggerSide.TestShowVisualizer(myString);
        }
    }
}
