﻿using Entities.Interfaces;
using FluentValidation;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tools
{
    public class ValidatorTools
    {
        public static bool Validates(IValidator validator, IEntity entity)
        {
            bool result = true;
            ValidationContext<IEntity> context = new ValidationContext<IEntity>(entity);
            var ValidationResult = validator.Validate(context);
            if (!ValidationResult.IsValid)
            {
                string message = "";
                foreach (var error in ValidationResult.Errors)
                {
                    message += error.ErrorMessage + "\n";
                }
                MessageBox.Show(message);
                result = false;
            }
            return result;
        }
    }
}
