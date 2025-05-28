using DataVerification.Services;
using System.Text.RegularExpressions;

namespace DataVerification.Rules
{
    public class PasswordValidation : IValidationRule<string>
    {
        public ValidationResult Validate(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                return new ValidationResult(false, "Password should contain at least 6 digits: ");

            if (!Regex.IsMatch(password, @"[A-Z]"))
                return new ValidationResult(false, "Password should at least have one uppercase: ");

            if (!Regex.IsMatch(password, @"[a-z]"))
                return new ValidationResult(false, "Password should at least have one lowercase: ");

            if (!Regex.IsMatch(password, @"[0-9]"))
                return new ValidationResult(false, "Password should at least have one digit:");

            return new ValidationResult(true, "Password is correct: ");
        }
    }
}