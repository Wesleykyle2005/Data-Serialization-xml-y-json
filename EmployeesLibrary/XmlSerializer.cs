using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EmployeesLibrary
{
    public class XmlSerializer : IDataRepository
    {
       

        public void Serialize<T>(T obj, string fileName)
        {
             var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (var fileStream = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(fileStream, obj);
            }
        }

        public T Deserialize<T>(string fileName)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (var fileStream = new FileStream(fileName, FileMode.Open))
            {
                return (T)serializer.Deserialize(fileStream);
            }
        }
    }
}
