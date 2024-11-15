using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Mapping
{
    public class ProductMap:EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            this.ToTable("Product");
            this.HasKey(p=> p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.ProductCode).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.ProductName).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(300);
            this.Property(p => p.UnitPrice1).HasPrecision(28,2);
            this.Property(p => p.UnitPrice2).HasPrecision(28, 2);
            this.Property(p => p.UnitPrice3).HasPrecision(28, 2);


            this.HasRequired(x => x.Menu).WithMany(x => x.Products).HasForeignKey(x=> x.MenuId);    
        }


    }
}
