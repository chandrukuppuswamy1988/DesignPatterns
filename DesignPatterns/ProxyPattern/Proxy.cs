using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : ISubject
    {
        Subject subject;
        public string Request()
        {
            if (subject == null) {
                Console.WriteLine("Subject inactive");
                subject = new Subject();
            }
            Console.WriteLine("Subject active");
            return "Proxy: call to " + subject.Request();
        }
    }
}
