using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeBase2.Interface
{
    interface GovtRules
    {
        public double EmployeePF(double basicSalary);
        public double LeaveDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);
    
    }
}
