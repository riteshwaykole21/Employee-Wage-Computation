using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHourPrMonth;
        private int totalEmpWage;
        public EmpWageBuilderObject (string company, int empRatePrHr, int numOfWorkingDays, int maxHourPrMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePrHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHourPrMonth = maxHourPrMonth;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0 , totalWorkingDays  = 0 ;
           
            while (totalEmpHrs <= this.maxHourPrMonth && totalWorkingDays <= numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0,3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);

            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage For Company :" + company +"is :"+ totalEmpWage);
            
        }
        public string Tostring()
        {
            return "Total Emp Wage For Company :" + this.company + "is:" + this.totalEmpWage;
        }
    }
}







