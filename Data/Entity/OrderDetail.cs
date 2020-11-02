using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTablolarınıÇekme.Data.Entity
{
    public class OrderDetail
    {
        int _orderID;
        int _productID;
        decimal _unitPrice;
        Int16 _quantity;
        Single _discount;

        [Key, Column(Order = 0)]
        public int OrderID
        {   get { return _orderID; }
            set { _orderID = value;}
        }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        [Key, Column(Order = 1)]
        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        public decimal UnitPrice
        {
            get { return _unitPrice;}
            set { _unitPrice = value; }
        }

        public Int16 Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public Single Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

    }
}
