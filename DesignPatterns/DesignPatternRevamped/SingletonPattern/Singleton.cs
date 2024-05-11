using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        // Private Constructor
        Singleton() { }

        // Private object instantiated with private constructor
        static readonly Singleton instance = new Singleton();

        // Public static property to get the object
        public static Singleton UniqueInstance
        {
            get { return instance; }

        }
    }
}
