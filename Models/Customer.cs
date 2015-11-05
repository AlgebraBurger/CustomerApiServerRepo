using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApiServer.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class CrmDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
