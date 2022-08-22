using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageDay10
{
    public class EmpWageBuilder2
    {

        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;


        public  EmpWageBuilder2()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int wagePerhour, int maxHoursPerMonth, int maxWorkingDays)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, wagePerhour, maxHoursPerMonth, maxWorkingDays);
            numOfCompany++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHours = 0, totalEmpHrs = 0, totalWorkingDays = 0;


            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.maxWorkingDays)
            {
                totalWorkingDays++;
                Random r = new Random();
                int empAttendance = r.Next(0, 3);
                switch (empAttendance)
                {
                    case FULL_TIME:
                        empHours = 8;
                        break;
                    case PART_TIME:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHrs += empHours;

            }
            Console.WriteLine("Total number of days worked " + totalWorkingDays + "\nToatal Employee hours : " + totalEmpHrs + "\n");
            return totalEmpHrs * companyEmpWage.wagePerHour;
        }
    }
}