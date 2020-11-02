using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTablolarınıÇekme.Data.Entity
{
    public class EmployeeTerritory
    {
        int _employeeID;
        string _territoryID;

        [Key, Column(Order = 0)]
        public int EmployeeID
        {   
            get { return _employeeID;}
            set { _employeeID = value;}
        }

        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }

        [Key,Column(Order=1)]
        public string TerritoryID
        {
            get { return _territoryID; }
            set { _territoryID = value; }
        }
        [ForeignKey("TerritoryID")]
        public virtual Territory Territory { get; set; }
    }
}
