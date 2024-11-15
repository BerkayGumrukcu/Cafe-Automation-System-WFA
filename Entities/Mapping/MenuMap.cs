﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Mapping
{
    public class MenuMap:EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            this.ToTable("Menu");
            this.HasKey(p=> p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.MenuName).HasColumnType("varchar").HasMaxLength(60);
            this.Property(p => p.MenuDescription).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}
