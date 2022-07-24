using ProxyPattern;

Console.WriteLine("Proxy Pattern\n");

ISubject subject = new Proxy();

Console.WriteLine(subject.Request());
Console.WriteLine(subject.Request());

subject = new ProtectionProxy();
Console.WriteLine(subject.Request());
Console.WriteLine((subject as ProtectionProxy).Authenticate("Secret"));
Console.WriteLine((subject as ProtectionProxy).Authenticate("Abracadabra"));
Console.WriteLine(subject.Request());
  