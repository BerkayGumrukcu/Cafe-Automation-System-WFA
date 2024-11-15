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
    public class TableMap: EntityTypeConfiguration<Table>
    {
        public TableMap()
        {
            this.ToTable("Table");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.TableName).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(300);
            this.Property(p => p.AddedDate).HasColumnType("Date");
        }
    }
}
