using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08
{
    public class Employee
    {
        // static attribute bukan milik object instance tapi milik class Employee
        public static int totalEmployee = 0;

        // instance atrribute
        private int empId;
        private string name;
        private int basicSalary;
        private DateTime joinDate;
        private string role;
        private decimal grossSalary;

        // default constructor
        public Employee()
        {
            this.empId = new Random().Next(100, 120);
            totalEmployee++;
        }

        //constructor with parameter
        public Employee(string name, int basicSalary, DateTime joinDate, string role)
        {
            this.empId = new Random().Next(100,120);
            this.name = name;
            this.basicSalary = basicSalary;
            this.joinDate = joinDate;
            this.role = role;
            totalEmployee++;
        }

        public override string? ToString()
        {
            return $"EmpId : {this.empId} Name : {this.name} salary : {this.basicSalary} ";
        }



        //getter setter
        public int EmpId { get => empId; set => empId = value; }
        public string Name { get => name; set => name = value; }
        public int BasicSalary { get => basicSalary; set => basicSalary = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public string Role { get => role; set => role = value; }
        public decimal GrossSalary { get => grossSalary; set => grossSalary = value; }
    }
}
