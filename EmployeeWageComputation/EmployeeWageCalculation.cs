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

        public static void CheckAttendances()
        {

            int empHrs = 0;
            int empWages = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < WORKING_DAYS; day++)
            {

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

                empWages = empHrs * EMP_RATE_PER_HR;
                totalEmpWage = totalEmpWage +empWages;
                Console.WriteLine("EmpWage:" + empWages);
             }
                Console.WriteLine("total emp wage : " +totalEmpWage);
        }
    }
}   

            
            
            
        
          
                
        
    

