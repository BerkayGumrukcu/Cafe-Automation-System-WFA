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
    public class TableAccountMap: EntityTypeConfiguration<TableAccount>
    {
        public TableAccountMap()
        {
            this.ToTable("TableAccount");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SaleCode).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(300);

            this.HasRequired(x=>x.Table).WithMany(x=>x.TableAccounts).HasForeignKey(x=>x.TableId);
        }
    }
}
