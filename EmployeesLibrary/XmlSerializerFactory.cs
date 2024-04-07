using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesLibrary
{
    public class XmlSerializerFactory : IDataRepositoryFactory
    {
        public IDataRepository CreateRepository()
        {
            return new XmlSerializer();
        }
    }
}
