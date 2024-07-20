using BaseLibrary;
using System;
using DerivedLibrary;

namespace MainProgram
{
    public class Program
    {
        static void Main(string[] arg)
        {
            DerivedClass derived = new DerivedClass();
            derived.CallBaseMethod();
        }
    }
}

