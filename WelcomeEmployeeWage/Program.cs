using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeEmployeeWage
{
    public class EmpWageBuilderObject
    {
        public const int isFullTime = 1;     // Constants
        public const int isPartTime = 2;     // Constants

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerPerMonth;
        private int totalEmpWage;
       
        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        { 
            int empHrs = 0;     // varibles
            int totalEmpHrs = 0;    // varibles
            int totalWorkingDays = 0;   // Varibles
            while(totalEmpHrs <= this.maxHoursPerPerMonth && totalWorkingDays < this.numOfWorkingDays)   //Using While loop
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
            int totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Employee Wage for company : " + company + "is: " + totalEmpWage);
            
        } 
        public string toString() 
        {
            return "Total Emp Wage for Company : " + this.company + "is: " + this.totalEmpWage;
        }
       
    }

}


