using Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class UserVAL:AbstractValidator<User>
    {
        public UserVAL()
        {
            RuleFor(p => p.FullName).NotEmpty().WithMessage("Ad Soyad Alanı Boş Geçilemez.");
            RuleFor(p => p.UserName).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez.");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez.");
            RuleFor(p => p.Phone).NotEmpty().WithMessage("Telefon Alanı Boş Geçilemez.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email Alanı Boş Geçilemez.");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Yanlış Email Adres Formatı.");
        }
    }
}
