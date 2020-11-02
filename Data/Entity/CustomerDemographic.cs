using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTablolarınıÇekme.Data.Entity
{
    public class CustomerDemographic
    {
        char _customerTypeID;
        [Key]
        public char CustomerTypeID
        {   get { return _customerTypeID; }
            set { _customerTypeID = value;}
        }
    }
}
