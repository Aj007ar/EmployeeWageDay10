using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageDay10
{
    internal class UC9_TotalWageCompany
    {
        public const int Part_Time = 2;
        public const int Full_Time = 1;

        private string company;
        private int empRatePerHr;
        private int numOfWorkDay;
        private int MaxWorkHr;
        private int totalwage;

        public UC9_TotalWageCompany(string company, int empRatePerHr, int numOfWorkDay, int MaxWorkHr)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkDay = numOfWorkDay;
            this.MaxWorkHr = MaxWorkHr;
        }
        public void Multi_Company_Wage()
        {
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
            Console.WriteLine("\nTotal Working Day: " + totalWorkDays);
            Console.WriteLine("Total Working hours " + totalEmpHrs);
            Console.WriteLine("Total Employee Wage for " + company + " is " + totalwage);
        }
    }
}
