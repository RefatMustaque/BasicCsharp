using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager
{
    class Customer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Nid { get; set; }

        public Customer(string firstName, string middleName, string lastName, string fatherName, string motherName, DateTime birthdate, string nid): this(firstName, middleName, lastName)
        {
            FatherName = fatherName;
            MotherName = motherName;
            Birthdate = birthdate;
            Nid = nid;
        }

        public Customer(string firstName, string middleName, string lastName):this(firstName, lastName)
        {
            MiddleName = middleName;
        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        private string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string GetCustomerInfo()
        {
            return "Full Name: " + GetFullName() + "\nFatherName: " + FatherName + "\nMotherName: " + MotherName + "\nBirthdate: " + Birthdate + "\nNID: " + Nid;
        }
    }
}
