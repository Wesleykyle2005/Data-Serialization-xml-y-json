﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesLibrary
{
    public interface IDataRepository
    {
        void Serialize<T>(T obj, string fileName);
        T Deserialize<T>(string fileName);
    }
}
