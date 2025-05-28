using DataVerification.Services;
using System.Text.RegularExpressions;

namespace DataVerification.Rules
{
    public class EmailValidation : IValidationRule<string>
    {
        public ValidationResult Validate(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return new ValidationResult(false, "Email is required: ");

            if (!Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w+$"))
                return new ValidationResult(false, "Wrong format: ");

            return new ValidationResult(true, "Email is correct: ");
        }
    }
}
