using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08
{
    internal interface IEmployee
    {
        // method return 
        List<Employee> GetAll();
        List<Employee> FindEmployeeByRole(List<Employee> empList,string roleName);
    }
}
