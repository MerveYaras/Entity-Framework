using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTablolarınıÇekme.Data.Entity
{
    public class Order
    {
        int _orderID;
        string _customerID;
        int _employeeID;
        DateTime _orderDate;
        DateTime _requiredDate;
        DateTime _shippedDate;
        int _shipVia;
        decimal _freight;
        string _shipName;
        string _shipAddress;
        string _shipCity;
        string _shipRegion;
        string _shipPostalCode;
        string _shipCountry;

        [Key]
        public int OrderID
        {   get { return _orderID; }
            set { _orderID = value;}
        }
               
        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

       [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }

        public int ShipVia
        {
            get { return _shipVia; }
            set { _shipVia = value; }
        }
        [ForeignKey("ShipVia")]
        public virtual Shipper Shipper { get; set; }


        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        public string ShipName
        {
            get { return _shipName; }
            set { _shipName = value; }
        }
        public string ShipAddress
        {
            get { return _shipAddress; }
            set { _shipAddress = value; }
        }
        public string ShipCity
        {
            get { return _shipCity; }
            set { _shipCity = value; }
        }
        public string ShipRegion
        {
            get { return _shipRegion; }
            set { _shipRegion = value; }
        }
        public string ShipPostalCode
        {
            get { return _shipPostalCode; }
            set { _shipPostalCode = value; }
        }
        public string ShipCountry
        {
            get { return _shipCountry; }
            set { _shipCountry = value; }
        }
        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }
        public DateTime RequiredDate
        {
            get { return _requiredDate; }
            set { _requiredDate = value; }
        }
        public DateTime ShippedDate
        {
            get { return _shippedDate; }
            set { _shippedDate = value; }
        }
        public decimal Freight
        {
            get { return _freight; }
            set { _freight = value; }
        }
        
    }
}
