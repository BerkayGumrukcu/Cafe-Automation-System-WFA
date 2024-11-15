﻿using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class UserAction:IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Description { get; set; }

        public DateTime DateTime { get; set; }

        public User User { get; set; }
    }
}
