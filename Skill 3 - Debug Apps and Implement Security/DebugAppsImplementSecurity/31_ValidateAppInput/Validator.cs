using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _31_ValidateAppInput
{
    public static class Validator<T>
    {
        public static IList<string> Validate(T entity)
        {
            var validationResults = new List<ValidationResult>();

            var validationContext = new ValidationContext(entity, null, null);

            Validator.TryValidateObject(entity, validationContext, validationResults, validateAllProperties: true);

            return validationResults.Select(v => v.ErrorMessage).ToList();
        }
    }
}
