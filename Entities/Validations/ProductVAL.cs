using Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class ProductVAL:AbstractValidator<Product>
    {
        public ProductVAL() 
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün Adı Alanı Boş Geçilemez.");
            RuleFor(p => p.ProductCode).NotEmpty().WithMessage("Ürün Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.UnitPrice1).NotEmpty().WithMessage("Birim Fiyatı 1 Boş Geçilemez.");
            RuleFor(p => p.UnitPrice2).NotEmpty().WithMessage("Birim Fiyatı 2 Boş Geçilemez.");
            RuleFor(p => p.UnitPrice3).NotEmpty().WithMessage("Birim Fiyatı 3 Boş Geçilemez.");
        }
    }
}
