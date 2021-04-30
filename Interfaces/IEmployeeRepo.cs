using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Interfaces
{
    public interface IEmployeeRepo
    {

        bool insertEmployee(Employee d);
        bool updateEmployee(Employee d);
        List<Employee> getAll();
        Employee getEmployee(string l);
        bool deleteEmployee(string s);
        
    }
}
