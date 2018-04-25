using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Middle Name ");
            string middleName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Father Name: ");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Enter Mother Name: ");
            string motherName = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth: ");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter National Id Card No: ");
            string nid = Console.ReadLine();
            Console.WriteLine("Enter Account Name: ");
            string accountName = Console.ReadLine();
            Console.WriteLine("Enter Account No: ");
            long accountNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Initial Balance: ");
            long balance = Convert.ToInt64(Console.ReadLine());

            Account tonmoy = new Account(accountName, accountNo, firstName, middleName, lastName, fatherName,motherName, birthdate, nid, balance);
            Console.WriteLine("\n\n\nReport of the account:");
            Console.WriteLine(tonmoy.GetReport());
            Console.ReadKey();
        }
    }
}
