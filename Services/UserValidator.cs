using DataVerification.Models;
using DataVerification.Rules;
using DataVerification.Services;
using System.Collections.Generic;

namespace DataVerification.Services
{
    public class UserValidator
    {
        private readonly List<IValidationRule<string>> _nameRules;
        private readonly List<IValidationRule<string>> _emailRules;
        private readonly List<IValidationRule<string>> _phoneRules;
        private readonly List<IValidationRule<string>> _passwordRules;

        public UserValidator()
        {
            _nameRules = new List<IValidationRule<string>> { new NameValidation() };
            _emailRules = new List<IValidationRule<string>> { new EmailValidation() };
            _phoneRules = new List<IValidationRule<string>> { new PhoneValidation() };
            _passwordRules = new List<IValidationRule<string>> { new PasswordValidation() };
        }

        public List<ValidationResult> Validate(User user)
        {
            var results = new List<ValidationResult>();

            _nameRules.ForEach(r => results.Add(r.Validate(user.Name)));
            _emailRules.ForEach(r => results.Add(r.Validate(user.Email)));
            _phoneRules.ForEach(r => results.Add(r.Validate(user.Phone)));
            _passwordRules.ForEach(r => results.Add(r.Validate(user.Password)));

            return results;
        }
    }
}