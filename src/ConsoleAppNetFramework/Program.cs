using ClassLibraryNetStandard;
using Newtonsoft.Json;
using System;

namespace ConsoleAppNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test { SomeProperty = "One", SomeOtherProperty = "Two" };
            Console.WriteLine($"Hello from .net framework! Here's one .net standard Test instance:{JsonConvert.SerializeObject(test)}");
            Console.ReadLine();
        }
    }
}
