using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageDay10
{
    internal class UC6EmpWageWhile
    {
        public void EmpWageTotal()
        {
            const int Part_Time = 2;
            const int Full_Time = 1;
            const int empRatePerHr = 20;
            const int numOfWorkDay = 20;
            const int MaxWorkHr = 100;

            int empHr = 0;
            int totalwage = 0;
            int totalWorkDays = 0;
            int totalEmpHrs = 0;

            while (totalWorkDays < numOfWorkDay && totalEmpHrs <= MaxWorkHr)
            {
                totalWorkDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case Full_Time:
                        empHr = 8;
                        break;
                    case Part_Time:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;

                }
                totalEmpHrs += empHr;
            }
            totalwage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Day: " + totalWorkDays + "\nEmployee working Hrs: " + totalEmpHrs);
            Console.WriteLine("Total Salary is: " + totalwage);
        }
    }
}
