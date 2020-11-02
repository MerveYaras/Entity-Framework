using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTablolarınıÇekme.Data.Entity
{
    public class Shipper
    {
        int _shipperID;
        string _companyName;
        string _phone;
        [Key]
        public int ShipperID
        {
            get { return _shipperID; }
            set { _shipperID = value; }
        }
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}
