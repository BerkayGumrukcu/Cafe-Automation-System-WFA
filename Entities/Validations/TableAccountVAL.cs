using Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class TableAccountVAL:AbstractValidator<TableAccount>
    {
        public TableAccountVAL() 
        {
            RuleFor(p => p.SaleCode).NotEmpty().WithMessage("Satış Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.SaleCode).Length(12).WithMessage("Satış Kodu 12 karakterden oluşmalıdır.");
            RuleFor(p => p.Quantity).NotEmpty().WithMessage("Miktar Alanı Boş Geçilemez.");
            RuleFor(p => p.Quantity).GreaterThan(0).WithMessage("Miktar Alanı Boş Geçilemez.");


            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Birim Fiyatı Boş Geçilemez.");
            RuleFor(p => p.UnitPrice).LessThanOrEqualTo(300).WithMessage("Birim Fiyatı En Fazla 300 Olur.");

        }
    }
}
