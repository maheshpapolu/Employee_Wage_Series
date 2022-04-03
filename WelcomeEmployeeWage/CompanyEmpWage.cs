using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeEmployeeWage
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) // Constructor
        {
            this.company = company;     // Arguments
            this.empRatePerHour = empRatePerHour; // Arguments
            this.numOfWorkingDays = numOfWorkingDays; // Arguments
            this.maxHoursPerMonth = maxHoursPerMonth; // arguments
        }
        public void setTotalEmpWage(int totalEmpWage)  //create a Method
        {
            this.totalEmpWage = totalEmpWage;
        }
        public override string ToString()
        {
            return "Total Emp Wage for Company : " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
