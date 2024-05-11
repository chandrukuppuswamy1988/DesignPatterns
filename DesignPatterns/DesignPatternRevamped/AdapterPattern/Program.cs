// See https://aka.ms/new-console-template for more information
// Showing the Adapteee in standalone mode

using AdapterPattern;

 Adaptee first = new Adaptee();
 Console.Write("Before the new standard\nPrecise reading: ");
 Console.WriteLine(first.SpecificRequest(5, 3));

 // What the client really wants
 ITarget second = new Adapter();
 Console.WriteLine("\nMoving to the new standard");
 Console.WriteLine(second.Request(5));


