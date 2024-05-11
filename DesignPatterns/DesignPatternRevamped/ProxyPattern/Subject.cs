using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Subject : ISubject
    {
        public string Request()
        {
            return "Subject Request " + "Choose left Door\n";
        }
    }
}
