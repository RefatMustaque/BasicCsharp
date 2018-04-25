using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager
{
    class Account
    {
        private  long balance;
        public string AccountName { get; set;}
        public long AccountNo { get; set; }
        public long Balance { get { return balance; } set { balance = balance + value; } }
        public Customer CustomerInfo { get; set; }

        public Account(string accountName, long accountNo, string firstName, string middleName, string lastName, string fatherName, string motherName, DateTime birthdate, string nid, long balance):this(accountName, accountNo, firstName, middleName, lastName, balance)
        {
            CustomerInfo = new Customer(firstName, middleName, lastName, fatherName, motherName, birthdate, nid);
        }

        public Account(string accountName, long accountNo, string firstName, string middleName, string lastName, long balance)
        {
            AccountName = accountName;
            AccountNo = accountNo;
            Balance = balance;
            CustomerInfo = new Customer(firstName, middleName, lastName);
        }

        private string GetCustomerInfo()
        {
            return CustomerInfo.GetCustomerInfo();
        }

        public string GetReport()
        {
            return "Account No: " + AccountNo + "\nAccount Name: "+ AccountName + "\n\nCustomer Info -\n"+GetCustomerInfo()+ "\n\nBalance: " + Balance;
        }
    }
}
