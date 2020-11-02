using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTablolarınıÇekme.Data.Entity
{
    public class Regionn
    {
        int _regionID;
        string _regionDescription;

        [Key]
        public int RegionID
        { 
            get { return _regionID; }
            set { _regionID = value; }
        }
        public string RegionDescription
        {
            get { return _regionDescription; }
            set { _regionDescription = value; }
        }
    }
}
