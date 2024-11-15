using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class TableAccount:IEntity
    {

        public int Id { get; set; }

        public string SaleCode { get; set; }

        public int TableId { get; set; }

        public int MenuId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public string Description { get; set; }

        public DateTime DateTime { get; set; }

        public Table Table { get; set; }
    }
}
