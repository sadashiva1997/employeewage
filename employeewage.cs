using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeproblems
{
    internal class employeewage
    {
        public static bool EmployeeWageProgram()
        {
            {
                Random attendance = new Random();

                if (attendance.Next(0, 2) == 1) return true;
                return false;
            }
        }
    }
}
