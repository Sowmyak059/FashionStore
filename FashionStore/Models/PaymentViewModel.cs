using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FashionStore.Models
{
    public class PaymentViewModel
    {
        [Required]
        [CreditCard]
        [Display(Name = "Card Number")]
        [CustomValidation(typeof(PaymentViewModel), nameof(ValidateCardNumber))]
        public string CardNumber { get; set; }

        [Required]
        [Display(Name = "Expiry Date")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(PaymentViewModel), nameof(ValidateExpiryDate))]
        public string ExpiryDate { get; set; }

        [Required]
        [RegularExpression(@"^\d{3,4}$", ErrorMessage = "Invalid CVV")]
        [Display(Name = "CVV")]
        public string CVV { get; set; }

        public static ValidationResult ValidateCardNumber(string cardNumber, ValidationContext context)
        {
            if (cardNumber != null && cardNumber.Length >= 12)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Invalid card number. Card number must be between 13 and 19 digits.");
        }

        public static ValidationResult ValidateExpiryDate(string expiryDate, ValidationContext context)
        {
            if (DateTime.TryParseExact(expiryDate, "MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                if (parsedDate > DateTime.Now)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Invalid expiry date");
        }
    }
}