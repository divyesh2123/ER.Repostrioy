using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public interface IEmpoyeeRepositroy
    {

        bool AddEmployee(Employee employee);

        bool DeleteEmployee(int employeeId);
        
        List<Employee> GetAllEmployees();

        bool UpdateEmployee(Employee employee);

       

        
    }
}
