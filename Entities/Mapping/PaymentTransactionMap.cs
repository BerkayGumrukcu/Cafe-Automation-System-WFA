using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mapping
{
    public class PaymentTransactionMap: EntityTypeConfiguration<PaymentTransaction>
    {
        public PaymentTransactionMap()
        {
            this.ToTable("PaymenTransaction");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SaleCode).HasColumnType("varchar").HasMaxLength(60);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}
