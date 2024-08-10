using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class EmpoyeeRepositroy : IEmpoyeeRepositroy
    {
        public bool AddEmployee(Employee employee)
        {           

            WeltecDatabase weltecDatabase = new WeltecDatabase();
            weltecDatabase.Employees.Add(employee);

           int d= weltecDatabase.SaveChanges();

            if(d>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
