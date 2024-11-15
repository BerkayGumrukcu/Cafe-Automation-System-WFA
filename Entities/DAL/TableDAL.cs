using Entities.Models;
using Entities.Repository;
using Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DAL
{
    public class TableDAL:EntityRepositoryBase<CafeContext, Table, TableVAL>
    {
        public object TableList(CafeContext context)
        {
            var model = (from t in context.Tables
                join u in context.Users on t.UserId equals u.Id into user
                from usertable in user.DefaultIfEmpty()
                select new
                {
                    t.Description,
                    t.Status,
                    t.AddedDate,
                    t.LastUpdatedDate,
                    t.Id,
                    t.Operation,
                    t.TableName,
                    t.IsReserved,
                    User = usertable.UserName
                }).ToList();
            return model;
        }
    }
}
