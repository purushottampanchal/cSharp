using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeBase2.Interface
{
    internal class TCS:GovtRules
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string dept { get; set; }
        public string desg { get; set; }
        public string basicSalary { get; set; }

        public double EmployeePF(double basicSalary)
        {
            throw new NotImplementedException();
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            throw new NotImplementedException();
        }

        public double LeaveDetails()
        {
            throw new NotImplementedException();
        }

        public TCS(int empId, string name, string dept, string desg, string basicSalary)
        {
            EmpId = empId;
            Name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public void display()
        {
            string str = 
                "EmpId:" +EmpId+
                " \nname: " +Name+
                " \ndept: " +dept+
                " \ndesg: " + desg+
                " \nbasic salary: " + basicSalary;
            Console.WriteLine("__________\n"+str);

        }
    }
}
