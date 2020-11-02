using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTablolarınıÇekme.Data.Entity
{
    public class Employee
    {
        int _employeeID;
        string _lastName;
        string _firstName;
        string _title;
        string _titleOfCourtesy;
        DateTime _birthDate;
        DateTime _hireDate;
        string _address;
        string _city;
        string _region;
        string _postalCode;
        string _country;
        string _homePhone;
        string _extension;
        int _reportsTo;
        string _photoPath;

        [Key]
        public int EmployeeID
        { 
            get { return _employeeID; }
            set { _employeeID = value;}
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string TitleOfCourtesy
        {
            get { return _titleOfCourtesy; }
            set { _titleOfCourtesy = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public DateTime  HireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Region
        {
            get { return _region; }
            set { _region = value; }
        }
        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string HomePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }
        public string Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }
               
        public int ReportsTo
        {
            get { return _reportsTo; }
            set { _reportsTo = value;}
        }
        
        [ForeignKey("ReportsTo")]
        public virtual Employee ReportsEmployees { get; set; }

        public string PhotoPath
        {
            get { return _photoPath; }
            set { _photoPath = value; }
        }

    }
}
