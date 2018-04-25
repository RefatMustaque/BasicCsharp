using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    class Address
    {
        public int HouseNo { get; set; }
        public int RoadNo { get; set; }
        public string AreaName { get; set; }
        public int PostalCode { get; set; }

        public Address()
        {

        }

        public Address(int houseNo, int roadNo, string areaName, int postalCode)
        {
            this.HouseNo = houseNo;
            this.RoadNo = roadNo;
            this.AreaName = areaName;
            this.PostalCode = postalCode;
        }

        public string GetFullAddress()
        {
            return $"House No: {this.HouseNo}, Road No: {this.RoadNo}, Area Name: {this.AreaName} & Postal Code: {this.PostalCode}";
        }
    }
}
