using System;
using Newtonsoft.Json;
using ClassLibraryNetStandard;

class Program
{
    static void Main(string[] args)
    {
        var test = new Test { SomeProperty = "One", SomeOtherProperty = "Two" };
        Console.WriteLine($"Hello from .net core! Here's one .net standard Test instance:{JsonConvert.SerializeObject(test)}");

        Console.ReadLine();
    }
}