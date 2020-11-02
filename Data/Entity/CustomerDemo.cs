using NorthwindTablolarınıÇekme.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTablolarınıÇekme
{
    public class CustomerDemo
    {
        char _customerID;
        char _customerTypeID;

        public char CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

       
        public char CustomerTypeID
        {
            get { return _customerTypeID; }
            set { _customerTypeID = value; }
        }

        [ForeignKey("CustomerTypeID")]
        public virtual  CustomerDemographic CustomerDemographic{ get; set; }
        
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

    }
}
