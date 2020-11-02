using NorthwindTablolarınıÇekme.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindTablolarınıÇekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           string[] tables = Enum.GetNames(typeof(TablesEnum));
            foreach (var item in tables)
            { 
                cmbTablolar.Items.Add(item.ToString());
            }
        }

        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            NorthwindDbContext tablo = new NorthwindDbContext();
            
            if (cmbTablolar.SelectedItem.ToString() == "Categories")
            {   List<Category> list = tablo.Categories.ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item.CategoryName);
                }
            }
            else if (cmbTablolar.SelectedItem.ToString() == "CustomerCustomerDemo")
            {
                //List<CustomerDemo> list = tablo.CustomerCustomerDemo.ToList();
                //foreach (var item in list)
                //{
                //    listBox1.Items.Add(item);
                //}
            }
            else if (cmbTablolar.SelectedItem.ToString() == "CustomerDemographics")
            {
                //List<CustomerDemographic> list = tablo.CustomerDemographics.ToList();
                //foreach (var item in list)
                //{
                //    listBox1.Items.Add(item);
                //}
            }
            else if (cmbTablolar.SelectedItem.ToString() == "Customers")
            {
                List<Customer> list = tablo.Customers.ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (cmbTablolar.SelectedItem.ToString() == "Employees")
            {
                List<Employee> list = tablo.Employees.ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (cmbTablolar.SelectedItem.ToString() == "EmployeeTerritories")
            {
                List<EmployeeTerritory> list = tablo.EmployeeTerritories.ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (cmbTablolar.SelectedItem.ToString() == "OrderDetails")
            {
                List<OrderDetail> list = tablo.OrderDetails.ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (cmbTablolar.SelectedItem.ToString() == "Orders")
            {
                List<Order> list = tablo.Orders.ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (cmbTablolar.SelectedItem.ToString() == "Products")
            {
                List<Product> categories = tablo.Products.ToList();
                foreach (var item in categories)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (cmbTablolar.SelectedItem.ToString() == "Region")
            {
                List<Regionn> list = tablo.Region.ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (cmbTablolar.SelectedItem.ToString() == "Shippers")
            {
                List<Shipper> list = tablo.Shippers.ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (cmbTablolar.SelectedItem.ToString() == "Suppliers")
            {
                List<Supplier> list = tablo.Suppliers.ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (cmbTablolar.SelectedItem.ToString() == "Territories")
            {
                List<Territory> list = tablo.Territories.ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
            }

            
          
        }
    }
}
