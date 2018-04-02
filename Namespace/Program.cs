using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//to use the class of other namespace we have to include it's namespace with the word "using".
//and for our case we have "AnotherClass" class inside the "AnotherNamespace" namespace
//and "AnotherNamespace" namespace is inside the "NamespaceExample" namespace
using NamespaceExample.AnotherNamespace;

namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object for the "AnotherClass" class
            AnotherClass hello = new AnotherClass();

            //accessing "ShowHelloWorld()" method inside the "AnotherClass()" class
            hello.ShowHelloWorld();
        }
    }
}
