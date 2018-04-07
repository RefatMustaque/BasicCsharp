using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Refat", "Bin", "Mustaque",  new DateTime(2016, 5, 2));

            Console.WriteLine("Employee Full Name: ");
            Console.WriteLine(employee.GetFullName());
            Console.WriteLine("Total Employment Duration: ");
            Console.WriteLine("Joining Date of Employee: ");
            Console.WriteLine(employee.JoiningDate.ToString("dd-MMM-yyyy"));
            Console.WriteLine("Todays Date: ");
            Console.WriteLine(DateTime.Now.ToString("dd-MMM-yyyy"));
            Console.WriteLine("Total Employment Duration: ");
            Console.WriteLine(employee.GetEmploymenDurationInDays().ToString() + " Days");

            Console.ReadKey();

        }
    }
}
