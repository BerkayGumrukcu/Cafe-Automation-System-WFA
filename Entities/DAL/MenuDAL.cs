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
    public class MenuDAL:EntityRepositoryBase<CafeContext, Menu, MenuVAL>
    {
    }
}
