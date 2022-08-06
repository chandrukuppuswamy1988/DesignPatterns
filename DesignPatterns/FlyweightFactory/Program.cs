// See https://aka.ms/new-console-template for more information
using FlyweightFactory;

int extrinsicstate = 22;
var factory = new FlyweightFactory.FlyweightFactory();
// Work with different flyweight instances
Flyweight fx = factory.GetFlyweight("X");
fx.Operation(--extrinsicstate);
Flyweight fy = factory.GetFlyweight("Y");
fy.Operation(--extrinsicstate);
Flyweight fz = factory.GetFlyweight("Z");
fz.Operation(--extrinsicstate);
UnsharedConcreteFlyweight fu = new
    UnsharedConcreteFlyweight();
fu.Operation(--extrinsicstate);
// Wait for user
Console.ReadKey();
