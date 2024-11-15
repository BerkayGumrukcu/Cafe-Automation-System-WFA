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
    public class ProductDAL: EntityRepositoryBase<CafeContext, Product, ProductVAL>
    {
        public object ProductList(CafeContext context)
        {
            var list = (from p in context.Products select new
            {
                p.Id,
                p.MenuId,
                Menu = p.Menu.MenuName,
                p.ProductCode,
                p.ProductName,
                p.UnitPrice1,
                p.UnitPrice2,
                p.UnitPrice3,
                p.Description,
                p.Image,
                p.Date
            }).ToList();
            return list;
        }
    }
}
