namespace EmpWageDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************WELCOME TO EMPLOYEE WAGE COMPUTATION*****************");
            Console.WriteLine("1.UC1 Employee Attendance");
            Console.WriteLine("2.UC2 Employee PartTime");
            Console.WriteLine("3.UC3 Employee DailyWage");
            Console.WriteLine("4.UC4 Employee Wage using Switch");
            Console.WriteLine("5.UC5 Employee Wage for a Month");
            Console.WriteLine("5.UC5 Employee Wage for a Month");
            Console.WriteLine("6.UC6 Employee Wage using while");
            Console.WriteLine("7.UC8 Multiple Company Wage: ");
            Console.WriteLine("8.UC9 Total wage for multiple company");
            Console.WriteLine("9.UC10 Total wage for multiple company using Arrays");
            Console.WriteLine("10.UC11 Total wage for multiple company using InterFace");
            Console.WriteLine("11.UC13 Total wage of company Daily and monthly");
            Console.WriteLine("12.UC14 Total wage for multiple company by quired");

            Console.WriteLine("\nEnter number for UC execute");
            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    Console.WriteLine("\n***************Employee Attendance***************************");
                    UC1EmplyeeAttendance emplyeeAttendance = new UC1EmplyeeAttendance();
                    emplyeeAttendance.CheckAttendance();
                    break;
                case 2:
                    Console.WriteLine("\n*****************Part_Time/Full_Time Wage*********************");
                    UC2PartTime partTime = new UC2PartTime();
                    partTime.PartTimeWage();
                    break;
                case 3:
                    Console.WriteLine("\n*****************Employee Wage*******************************");
                    UC3EmployeeWage wage = new UC3EmployeeWage();
                    wage.DailyWage();
                    break;
                case 4:
                    Console.WriteLine("\n*************Epmloyee wage using Switch Case*******************");
                    UC4EmpWageSwitch wageCase = new UC4EmpWageSwitch();
                    wageCase.Empwage();
                    break;
                case 5:
                    Console.WriteLine("\n**************Total Salary For Month****************************");
                    UC5EmpWageMonth totalWage = new UC5EmpWageMonth();
                    totalWage.EmpWageMonth();
                    break;
                case 6:
                    Console.WriteLine("\n***************Max Salary using While****************************");
                    UC6EmpWageWhile obj1 = new UC6EmpWageWhile();
                    obj1.EmpWageTotal();
                    break;
                case 7:
                    Console.WriteLine("\n************multiple Company Wage************");
                    UC8_EmpWageMultiCompany uC8_Emp = new UC8_EmpWageMultiCompany();
                    uC8_Emp.Multi_Company_Wage("Tata", 20, 20, 100);
                    uC8_Emp.Multi_Company_Wage("infosys", 30, 20, 100);
                    break;
                case 8:
                    UC9_TotalWageCompany tata = new UC9_TotalWageCompany("tata", 20, 20, 100);
                    UC9_TotalWageCompany Bridgelabz = new UC9_TotalWageCompany("Bridgelabz", 20, 20, 100);
                    Bridgelabz.Multi_Company_Wage();
                    tata.Multi_Company_Wage();
                    break;
                case 9:
                    EmpWageBuilder2 empWage = new EmpWageBuilder2();
                    empWage.addCompanyEmpWage("Tata", 20, 100, 20);
                    empWage.ComputeEmpWage();
                    break;
                case 10:
                    EmpBuilder builder = new EmpBuilder();
                    builder.AddCompanyEmpWage("Tata", 20, 100, 20);
                    builder.ComputeEmpWage();
                    break;
                case 11:
                    BuilderWage builder1 = new BuilderWage();
                    builder1.AddCompanyEmpWage("Tata", 20, 100, 20);
                    builder1.ComputeEmpWage();
                    break;
                case 12:
                    EmpBuilderWage1 empBuilder = new EmpBuilderWage1();
                    empBuilder.AddCompanyEmpWage("Tata", 20, 100, 20);
                    empBuilder.ComputeEmpWage();
                    break;
            }
        }

    }
}
