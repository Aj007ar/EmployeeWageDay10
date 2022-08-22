using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageDay10
{
    internal class UC5EmpWageMonth
    {
        public void EmpWageMonth()
        {
            const int Part_Time = 2;
            const int Full_Time = 1;
            const int empRatePerHr = 20;
            const int numOfWorkDay = 20;

            int empHr = 0;
            int totalwage = 0;

            for (int i = 1; i <= numOfWorkDay; i++)
            {
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
                int salary = empHr * empRatePerHr;
                totalwage += salary;
            }
            Console.WriteLine("Employee wage for month is:" + totalwage);
        }
    }
}
