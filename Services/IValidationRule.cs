using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVerification.Services
{
    public interface IValidationRule<T>
    {
        ValidationResult Validate(T input);
    }
}
