using Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class TableVAL:AbstractValidator<Table>
    {
        public TableVAL() 
        {
            RuleFor(p => p.TableName).NotEmpty().WithMessage("Masa Adı Alanı Boş Geçilemez.");
        }
    }
}
