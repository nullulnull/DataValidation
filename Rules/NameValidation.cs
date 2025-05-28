using DataVerification.Services;
using System.Text.RegularExpressions;

namespace DataVerification.Rules
{
    public class NameValidation : IValidationRule<string>
    {
        public ValidationResult Validate(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return new ValidationResult(false, "Name is required: ");

            if (!Regex.IsMatch(name, @"^[A-ZԱ-Ֆ][a-zա-ֆ]{1,29}$"))
                return new ValidationResult(false, "Name should start with uppercase and include letters: ");

            return new ValidationResult(true, "Name is correct: ");
        }
    }
}