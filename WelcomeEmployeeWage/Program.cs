using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeEmployeeWage
{
    public class EmpWageBuilderArray
    {
        public const int isFullTime = 1;     // Constants
        public const int isPartTime = 2;     // Constants

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;  // creating Array

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5]; 
        }
            
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        
        
    public void computeEmpWage()
    {
        for (int i = 0; i < numOfCompany; i++)
        {
            companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
            Console.WriteLine(this.companyEmpWageArray[i].ToString());
        }
    }
    private int computeEmpWage(CompanyEmpWage companyEmpWage)
            {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while(totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.maxHoursPerMonth) 
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
                return totalEmpHrs * companyEmpWage.empRatePerHour;
        } 
       
       
    }

}


