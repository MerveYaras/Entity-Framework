using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTablolarınıÇekme.Data.Entity
{
    public class Territory
    {
        string _territoryID;
        string _territoryDescription;
        int _regionID;

        [Key]
        public string TerritoryID
        {
            get { return _territoryID; }
            set { _territoryID = value; }
        }
        public string TerritoryDescription
        {
            get { return _territoryDescription; }
            set { _territoryDescription = value; }
        }
        public int RegionID
        {
            get { return _regionID; }
            set { _regionID = value; }
        }

        [ForeignKey("RegionID")]
        public virtual Regionn Regionn {get;set;}
    }
}
