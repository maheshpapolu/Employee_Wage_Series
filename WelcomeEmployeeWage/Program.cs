using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeEmployeeWage
{
    internal class Employee_Daily_Wage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UC2_Employee_Daily_Wage\n");
            int isFullTime = 1;     // Constants
            int empRatePerHour = 20;    // Constants
            int empHrs = 0;     // varibles
            int empWage = 0;    // varibles
            Random random = new Random();   // Instantiate random number generator using supplied value as seed.
            int empCheck = random.Next(0,2);    // Generate 2 random integer values(0,1)
            if (empCheck == isFullTime)     // using if Statement
            {
                empHrs = 8;
            }
            else 
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
