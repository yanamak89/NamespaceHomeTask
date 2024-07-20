using System;
using MyNamespace.Collections;

namespace MyDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            myDict.Add("one", 1);
            myDict.Add("two", 2);

            if (myDict.TryGetValue("one", out int value))
            {
                Console.WriteLine($"Key: one, Value: {value}");
            }
            Console.WriteLine($"Total items: {myDict.Count}");
        }
    }
}

