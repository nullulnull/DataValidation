using DataVerification.Services;
using System.Text.RegularExpressions;

namespace DataVerification.Rules
{
    public class PhoneValidation : IValidationRule<string>
    {
        public ValidationResult Validate(string phone)
        {
            if (!Regex.IsMatch(phone, @"^\d{8,12}$"))
                return new ValidationResult(false, "Phone number should contain 8-12 digits: ");

            return new ValidationResult(true, "Phone correct: ");
        }
    }
}