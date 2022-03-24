using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08
{
    internal class EmployeeImpl : IEmployee
    {
        public List<Employee> FindEmployeeByRole(List<Employee> empList, string roleName)
        {
            return empList.FindAll(e => e.Role.Contains(roleName));
            //throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            Employee emp1 = new Employee("Agus", 15_000_000, new DateTime(2015, 3, 12), "Manager");
            Employee emp2 = new Employee("Budi", 6_000_000, new DateTime(2015, 3, 12), "Asisten");
            Employee emp3 = new Employee("Charlie", 5_500_000, new DateTime(2018, 3, 12), "Sales");
            Employee emp4 = new Employee("Dian", 4_500_000, new DateTime(2018, 3, 12), "Sales");
            Permanent emp5 = new Permanent("Herlis", 15_000_000, new DateTime(2019, 8, 11), "Net Developer");
            Employee emp6 = new Permanent("Viona", 11_000_000, new DateTime(2019, 8, 11), "Mobile App Developer");

            return new List<Employee> { emp1, emp2, emp3, emp4, emp5, emp6 };

           // throw new NotImplementedException();
        }
    }
}
