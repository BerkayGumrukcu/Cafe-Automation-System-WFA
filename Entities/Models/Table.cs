using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Table:IEntity
    {
        public int Id { get; set; }

        public string TableName { get; set; }

        public string Description { get; set; }

        public bool Status {  get; set; }

        public bool IsReserved { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public string Operation { get; set; }

        public int? UserId { get; set; }

        public ICollection<TableAccount> TableAccounts { get; set; }
    }
}
