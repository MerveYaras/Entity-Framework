using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTablolarınıÇekme.Data.Entity
{
    public class NorthwindDbContext :DbContext
    {
        public NorthwindDbContext()
        { Database.Connection.ConnectionString ="server=.;database=Northwind;trusted_connection=true"; }

        public DbSet<Category> Categories { get; set; }
       // public DbSet<CustomerDemo> CustomerCustomerDemo { get; set; }
       // public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Regionn> Region { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Territory> Territories { get; set; }

    }
}
