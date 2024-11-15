using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Menu:IEntity
    {

        public int Id { get; set; }


        public string MenuName { get; set; }


        public string MenuDescription { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
