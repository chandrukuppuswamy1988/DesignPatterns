﻿// See https://aka.ms/new-console-template for more information
using BuilderPattern;

Director director = new Director();

IBuilder b1 = new Builder1();
IBuilder b2 = new Builder2();

//Construct two products
director.Construct(b1);
Product p1 = b1.GetResult();
p1.Display();

director.Construct(b2);
Product p2 = b2.GetResult();

p2.Display();

