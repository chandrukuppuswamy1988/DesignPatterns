// See https://aka.ms/new-console-template for more information
using ChainOfResponsibilityPattern;

Handler start = null;
for (int i = 5; i > 0; i--)
{
    Console.WriteLine("Handler " + i + " deals up to a limit of " + i * 1000);
    start = new Handler(i, start);
}

int[] a = { 50, 2000, 1500, 10000, 175, 4500 };

foreach (int i in a)
    Console.WriteLine(start.HandleRequest(i));



