using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace day08
{
    public class Permanent : Employee
    {
        private decimal medical;
        public Permanent(string name, int basicSalary, DateTime joinDate, string role) : base(name, basicSalary, joinDate, role)
        {
            this.medical = basicSalary * (decimal.Divide(3,12));// 3/12
        }

        public override string? ToString()
        {
            return $"{base.ToString()} medical : {this.medical.ToString("C",new CultureInfo("id-ID"))}";
        }

        public decimal Medical { get => medical; set => medical = value; }
    }
}
