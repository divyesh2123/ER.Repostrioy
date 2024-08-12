using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class EmpoyeeRepositroy : IEmpoyeeRepositroy
    {
        WeltecDatabase weltecDatabase = new WeltecDatabase();
        public bool AddEmployee(Employee employee)
        {           

          
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
            

           

            var d = weltecDatabase.Employees.Where(y => y.Id == employeeId);
            weltecDatabase.Employees.RemoveRange(d);
            int d1 = weltecDatabase.SaveChanges();

            if (d1 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


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
