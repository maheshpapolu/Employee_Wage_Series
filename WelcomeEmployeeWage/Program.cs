using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeEmployeeWage
{
    internal class Add_Part_time_Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UC3_Add_Part_Time_Employee\n");
            int isFullTime = 1;     // Constants
            int isPartTime = 2;     // Constants
            int empRatePerHour = 20;    // Constants
            int empHrs = 0;     // varibles
            int empWage = 0;    // varibles
            Random random = new Random();   // Instantiate random number generator using supplied value as seed.
            int empCheck = random.Next(0,3);    // Generate 3 random integer values(0,1,2)
            if (empCheck == isFullTime)     // using if Statement
            {
                empHrs = 8;
            }
            else if (empCheck == isPartTime) 
            {
                empHrs = 4;
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
