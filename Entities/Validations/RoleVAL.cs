using Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class RoleVAL: AbstractValidator<Role>
    {
        public RoleVAL() 
        {

        }
    }
}
