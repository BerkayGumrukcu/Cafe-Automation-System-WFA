using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Role:IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string FormName { get; set; }

        public string ControlName { get; set; }

        public string ControlCaption { get; set; }
    }
}
