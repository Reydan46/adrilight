using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace adrilight.ValidationRules
{
    internal class NumberRangeValidationRule : ValidationRule
    {
        public int? Minimum { get; set; }
        public int? Maximum { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var stringValue = value as string;

            if (string.IsNullOrWhiteSpace(stringValue))
            {
                return ValidationResult.ValidResult;
            }

            if (!int.TryParse(stringValue.Trim(), out var intVal))
            {
                return new ValidationResult(false, "Пожалуйста, введите число!");
            }

            if (Minimum.HasValue && intVal < Minimum.Value)
            {
                return new ValidationResult(false, $"Пожалуйста, введите число больше или равное {Minimum}!");
            }

            if (Maximum.HasValue && intVal > Maximum.Value)
            {
                return new ValidationResult(false, $"Пожалуйста, введите число меньше или равное {Maximum}!");
            }

            return ValidationResult.ValidResult;
        }
    }
}
