using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class DeeperData
    {
        public string Data { get; set; }
        public DeeperData(string s)
        {
            Data = s;
        }
        public override string ToString()
        {
            return Data;
        }
    }
    public abstract class IPrototype<T>
    {

        // Shallow copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }
        public T DeepCopy()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T)formatter.Deserialize(stream);
            stream.Close();
            return copy;
        }

    }


}
