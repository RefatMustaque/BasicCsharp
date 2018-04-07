using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    class Employee
    {
        public Address PresentAddress { get; set; }
        public Address PermanentAddress { get; set; }
        public Name EmployeeName { get; set; }
        public int EmployeeNo { get; set; }
        public DateTime JoiningDate { get; set; }
        
        public Employee()
        {
            EmployeeName = new Name();
            JoiningDate = DateTime.Now;
        }

        public Employee(string FirstName, string MiddleName, string LastName, DateTime JoiningDate, int preHouseNo, int preRoadNo, string preAreaName, int prePostalCode, int perHouseNo, int perRoadNo, string areaName, int perPostalCode) : this(FirstName, MiddleName, LastName, preHouseNo, preRoadNo, preAreaName, prePostalCode, perHouseNo, perRoadNo, perAreaName, perPostalCode )
        {
            this.JoiningDate = JoiningDate;
        }

        public Employee(string FirstName, string MiddleName, string LastName, int preHouseNo, int preRoadNo, string preAreaName, int prePostalCode, int perHouseNo, int perRoadNo, string perAreaName, int perPostalCode ):this()
        {
            this.EmployeeName = new Name(FirstName, MiddleName, LastName);
            this.PresentAddress = new Address(preHouseNo, preRoadNo, preAreaName, prePostalCode);
            this.PermanentAddress = new Address(perHouseNo, perRoadNo, perAreaName, perPostalCode);
        }


        public string GetFullName()
        {
            return this.EmployeeName.GetFullName();
        }

        public int GetEmploymenDurationInDays()
        {
            TimeSpan timeSpent = (DateTime.Now - JoiningDate);
            return timeSpent.Days;
        }
        
    }
}
