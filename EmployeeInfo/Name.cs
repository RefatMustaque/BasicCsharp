using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    class Name
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; } 

        public  Name()
        {

        }

        public Name(string FirstName, string MiddleName, string LastName)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
        }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }
    }
}
