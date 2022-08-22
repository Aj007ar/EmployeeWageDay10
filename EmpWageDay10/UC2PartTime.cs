using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageDay10
{
    internal class UC2PartTime
    {
        public void PartTimeWage()
        {
            int Full_Time = 1;
            int Part_Time = 0;
            int empRatePerHr = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == 1)
            {
                int empHour = 8;
                int salary = (empRatePerHr * empHour);
                Console.WriteLine("Employee present for full day then salary is: " + salary);
            }
            else if (empCheck == 2)
            {
                int empHour = 4;
                int salary = (empRatePerHr * empHour);
                Console.WriteLine("Employee present for half day then salary is: " + salary);
            }
            else
            {
                int salary = 0;
                Console.WriteLine("Employee is absent then salary is:" + salary);
            }
        }
    }
}
