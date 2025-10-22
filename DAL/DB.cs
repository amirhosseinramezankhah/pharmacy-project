using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;

namespace DAL
{
    public class DB: DbContext
    {
        public DB(): base("conr")
        {

        }
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Product> Products { get; set; }    
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Activity> Activitys { get; set; }
        public DbSet<ActivityCategory> ActivityCategories { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserGroup> userGroups { get; set; }
        public DbSet<UserAccessRole> UserAccessRoles { get; set; }








    }
}
