using System;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        var test1 = new ClassLibraryNetStandard.Test { SomeProperty = "One", SomeOtherProperty = "Two" };
        Console.WriteLine($"Hello from .net core! Here's one .net standard Test instance:{JsonConvert.SerializeObject(test1)}");

        var test2 = new ClassLibraryNetFramework1.Test { SomeProperty = "One", SomeOtherProperty = 2 };
        Console.WriteLine($"Here's one .net framework Test instance:{JsonConvert.SerializeObject(test2)}");

        Console.ReadLine();
    }
}