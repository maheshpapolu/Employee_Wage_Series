using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeEmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject Mahindra = new EmpWageBuilderObject("Mahindra", 20, 20, 100);
            EmpWageBuilderObject Accenture = new EmpWageBuilderObject("Accenture", 30, 25, 120);
            Mahindra.computeEmpWage();
            Console.WriteLine(Mahindra.toString());
            Accenture.computeEmpWage();
            Console.WriteLine(Accenture.ToString());

        }
    }
}
