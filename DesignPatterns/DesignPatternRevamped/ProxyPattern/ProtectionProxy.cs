using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProtectionProxy : ISubject
    {

         Subject subject;
         string password = "Abracadabra";

        public string Authenticate(string supplied)
        {
            if (supplied != password)
                  return "Protection Proxy: No access";
            else
                  subject = new Subject();
              return "Protection Proxy: Authenticated";
          }
        public string Request()
        {
             if (subject == null)
                   return "Protection Proxy: Authenticate first";
             else return "Protection Proxy: Call to " +
               subject.Request();
           }
   }
 }



