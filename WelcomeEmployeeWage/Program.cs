using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeEmployeeWage
{
    internal class Employee_Attendence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome_to_Employee_wage_Program\n");
            Console.WriteLine("UC1_Check_Employee_is_Present_or_Absent\n");
            int isFullTime = 1;     // Constants
            Random random = new Random();   // Instantiate random number generator using supplied value as seed.
            int empCheck = random.Next(0,2);    // Generate 2 random integer values(0,1)
            if (empCheck == isFullTime)     // using if Statement
            {
                Console.WriteLine("Employee is Present");
            }
            else 
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
