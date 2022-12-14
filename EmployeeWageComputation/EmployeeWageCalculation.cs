using System;
using System.Collections.Generic;
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

        public static void CheckAttendances()
        {

            int empHrs = 0;
            int empWages = 0;

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
            Console.WriteLine("EmpWage:" + empWages);
        }
    }
}   

            
            
            
        
          
                
        
    

