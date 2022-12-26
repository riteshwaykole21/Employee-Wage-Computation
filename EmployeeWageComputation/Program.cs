using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Company Name: ");
            string company = Console.ReadLine();
            Console.WriteLine("Enter the Rate per Hour: ");
            int empRatePrHr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number of Working Days: ");
            int numOfWorkingDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number of Max Hour Per Month: ");
            int maxHourPrMonth = Convert.ToInt32(Console.ReadLine());

            EmployeeWageCalculation empWage = new EmployeeWageCalculation();
            empWage.ComputeEmployeeWage(company, empRatePrHr, numOfWorkingDays, maxHourPrMonth);
        }
    }
}