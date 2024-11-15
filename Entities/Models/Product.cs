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
    public class Product:IEntity
    {
        public int Id { get; set; }

        public int MenuId { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice1 { get; set; }

        public decimal UnitPrice2 { get; set; }

        public decimal UnitPrice3 { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
        public DateTime Date {  get; set; }

        public Menu Menu { get; set; }

    }
}
