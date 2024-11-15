using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User:IEntity
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Phone {  get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ReminderQuest {  get; set; }

        public string Reply {  get; set; }

        public string Description { get; set; }

        public DateTime RegisterDate { get; set; }

        public bool IsActive { get; set; }

        public ICollection<UserAction> UserActions { get; set; }
    }
}
