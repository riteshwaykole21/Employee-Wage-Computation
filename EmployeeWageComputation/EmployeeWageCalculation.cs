using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWageCalculation
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTHS = 100;

        public static void CheckAttendances()
        {

            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while(totalEmpHrs <= MAX_HRS_IN_MONTHS &&  totalWorkingDays < WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                Console.WriteLine("Days:" +totalWorkingDays+ "Emp Hrs :" +empHrs);
            }
                int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
                Console.WriteLine("total emp wage : " +totalEmpWage);
        }
    }
}   

            
            
            
        
          
                
        
    

