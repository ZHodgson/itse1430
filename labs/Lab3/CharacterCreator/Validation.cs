/*Zachary Hodgson
 * ITSE 1430
 * Mr. Taylor
 * Lab 3
 * 4/21/2020
 */

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator
{
    public static class Validation
    {
        public static IEnumerable<ValidationResult> Validate ( object value )
        {
            var errors = new List<ValidationResult>();
            Validator.TryValidateObject(value, new ValidationContext(value), errors, true);

            return errors;
        }
    }
}
