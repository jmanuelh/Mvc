﻿namespace Microsoft.AspNet.Mvc.ModelBinding
{
    /// <summary>
    /// Represents client side validation rule that determines if two values are equal.
    /// </summary>
    public class ModelClientValidationEqualToRule : ModelClientValidationRule
    {
        private const string EqualToValidationType = "equalto";
        private const string EqualToValidationParameter = "other";

        public ModelClientValidationEqualToRule([NotNull] string errorMessage, 
                                                [NotNull] object other)
            : base(EqualToValidationType, errorMessage)
        {
            ValidationParameters[EqualToValidationParameter] = other;
        }
    }
}
