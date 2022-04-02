using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeEmployeeWage
{
    class UC4_Employee_Wage_Using_Switch
    {
        public const int isFullTime = 1;     // Constants
        public const int isPartTime = 2;     // Constants
        public const int empRatePerHour = 20;    // Constants
    
    
        static void Main(string[] args)
        {
            int empHrs = 0;     // varibles
            int empWage = 0;    // varibles
            Random random = new Random();   // Instantiate random number generator using supplied value as seed.
            int empCheck = random.Next(0,3);    // Generate 3 random integer values(0,1,2)
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
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
