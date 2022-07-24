// See https://aka.ms/new-console-template for more information
using BridgePattern;

Console.WriteLine("Bridge Pattern\n");
Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
Console.WriteLine(new Abstraction(new ImplementationB()).Operation());

