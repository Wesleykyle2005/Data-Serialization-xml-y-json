using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesLibrary
{
    public class Empleados
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }   
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Empleados( string firstName, string lastName, string department, decimal salary)
        {
           
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Salary = salary;
        }

        public Empleados() : this( string.Empty, string.Empty, string.Empty, 0M) { }
    }
}

    
