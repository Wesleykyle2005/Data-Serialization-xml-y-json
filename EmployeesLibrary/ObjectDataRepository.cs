using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesLibrary
{  
    public class ObjectDataRepository
    {
        private readonly IDataRepositoryFactory _factory;
        

        public ObjectDataRepository(IDataRepositoryFactory factory)
        {
            _factory = factory;
        }

        public void Serialize<T>(T obj, string fileName)
        {
            IDataRepository dataRepository = _factory.CreateRepository();   
            dataRepository.Serialize(obj, fileName);
        }

        public T Deserialize<T>(string fileName)
        {
            IDataRepository dataRepository = _factory.CreateRepository();
            return dataRepository.Deserialize<T>(fileName);
        }

       
    }
}
