using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeEmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.AddCompanyEmpWage("Mahindra", 20, 20, 100);
            empWageBuilder.AddCompanyEmpWage("Accenture", 30, 25, 120);
            empWageBuilder.computeEmpWage();
            Console.ReadLine();


        }
    }
}
