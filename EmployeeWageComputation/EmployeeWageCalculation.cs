using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWageCalculation
    {
        public static void CheckAttendances()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HR = 20;

            int empHrs = 0;
            int empWages = 0;

            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is a Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWages = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("EmpWage:" + empWages);
        }
    }
}           
                
        
    

