using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PaymentTransaction:IEntity
    {
        public int Id { get; set; }

        public string SaleCode { get; set; }

        public string PaymentType { get; set; }

        public decimal PaidPrice { get; set; }

        public string Description { get; set; }

        public DateTime DateTime { get; set; }
    }
}
