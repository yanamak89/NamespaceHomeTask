using BaseLibrary;
using System;

namespace DerivedLibrary
{
    public class DerivedClass : BaseClass
    {
        public void CallBaseMethod()
        {
            PublicMethod();
        }
    }
}
