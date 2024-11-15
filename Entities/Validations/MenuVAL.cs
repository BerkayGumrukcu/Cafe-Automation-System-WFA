using Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class MenuVAL:AbstractValidator<Menu>
    {
        public MenuVAL() 
        {
            RuleFor(p => p.MenuName).NotEmpty().WithMessage("Menü Adı Alanı Boş Geçilemez.");
            RuleFor(p => p.MenuName).MinimumLength(3).WithMessage("Menü Adı Alanı En Az 3 Karakterden Oluşmalıdır.");
            RuleFor(p => p.MenuName).MaximumLength(15).WithMessage("Menü Adı Alanı En Fazla 15 Karakterden Oluşmalıdır.");
        }
    }
}
