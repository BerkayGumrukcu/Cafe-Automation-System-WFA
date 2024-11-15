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
    public class UserActionMap: EntityTypeConfiguration<UserAction>
    {
        public UserActionMap() 
        {
            this.ToTable("UserAction");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(300);

            this.HasRequired(x=> x.User).WithMany(x=> x.UserActions).HasForeignKey(x=>x.UserId);
        }
    }
}
