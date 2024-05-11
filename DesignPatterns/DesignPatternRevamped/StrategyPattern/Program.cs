// See https://aka.ms/new-console-template for more information
using StrategyPattern;

Console.WriteLine("Hello, World!");

Context context = new Context();
context.SwitchStrategy();
Random r = new Random(37);

for (int i = Context.start; i <= Context.start + 15; i++)
{
    if (r.Next(3) == 2)
    {
        Console.Write("|| ");
        context.SwitchStrategy();
    }
}