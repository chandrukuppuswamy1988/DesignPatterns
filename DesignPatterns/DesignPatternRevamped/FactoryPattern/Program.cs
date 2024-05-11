// See https://aka.ms/new-console-template for more information
using FactoryPattern;

Creator c = new Creator();

IProduct product;

for (int i = 1; i <= 12; i++)
{
    product = c.FactoryMethod(i);
    Console.WriteLine("Avocados " + product.ShipFrom());
}


