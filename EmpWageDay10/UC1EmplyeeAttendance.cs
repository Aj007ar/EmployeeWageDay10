using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageDay10
{
    internal class UC1EmplyeeAttendance
    {
        public void CheckAttendance()
        {
            int Full_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
