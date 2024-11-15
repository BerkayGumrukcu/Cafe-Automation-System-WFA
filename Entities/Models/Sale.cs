using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Sale:IEntity
    {
        public int Id { get; set; }

        public string SaleCode { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal PaidPrice { get; set; }

        public decimal RemainPrice { get; set; }

        public string Description { get; set; }

        public DateTime LastUpdatedTime { get; set; }
    }
}
