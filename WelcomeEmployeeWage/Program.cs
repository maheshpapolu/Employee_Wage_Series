using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeEmployeeWage
{
    class UC7_Compute_Employee_Wage_Using_Class_Methods
    {
        public const int isFullTime = 1;     // Constants
        public const int isPartTime = 2;     // Constants
        public const int empRatePerHour = 20;    // Constants
        public const int numOfWorkingDays = 20;     //Constants
        public const int maxHrsInMonth = 100;   // Constants
        public static void  computeEmpWage() 
        { 
            int empHrs = 0;     // varibles
            int totalEmpHrs = 0;    // varibles
            int totalWorkingDays = 0;   // Varibles
            while(empHrs <= maxHrsInMonth && totalWorkingDays < numOfWorkingDays)   //Using While loop
            {
                totalWorkingDays++; // using increment Condition
                Random random = new Random();   // Instantiate random number generator using supplied value as seed.
                int empCheck = random.Next(0, 3);    // Generate 3 random integer values(0,1,2)
                switch (empCheck)      // using Switch Statement
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        } 
        static void Main(string[] args) 
        {
            computeEmpWage();
        }
    }

}
