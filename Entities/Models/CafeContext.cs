using Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CafeContext : DbContext
    {
        public CafeContext(): base("name=connection")
        {
             
        }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet <Table> Tables { get; set; }

        public DbSet<TableAccount> TableAccounts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserAction> UserActions {  get; set; }
        
        public DbSet<Sale> Sales { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new TableMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserActionMap());
            modelBuilder.Configurations.Add(new SaleMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new PaymentTransactionMap());
            modelBuilder.Configurations.Add(new TableAccountMap());
        }
    }
}
