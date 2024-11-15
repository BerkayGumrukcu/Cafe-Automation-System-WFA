using Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class SaleVAL:AbstractValidator<Sale>
    {
       public SaleVAL() {
            RuleFor(p => p.SaleCode).Length(12).WithMessage("Satış Kodu 12 karakterden oluşmalıdır.");
            RuleFor(p => p.SaleCode).NotEmpty().WithMessage("Satış Kodu Alanı Boş Geçilemez.");
            
        }
    }
}
