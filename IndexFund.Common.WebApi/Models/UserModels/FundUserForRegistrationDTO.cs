using System.ComponentModel.DataAnnotations;

namespace IndexFund.Common.WebApi.Models
{
    public class FundUserForRegistrationDTO
    {
        [MinLength(3), MaxLength(64)]
        public string Firstname { get; set; } = string.Empty;

        [MinLength(3), MaxLength(64)]
        public string Lastname { get; set; } = string.Empty;

        [MinLength(3), MaxLength(64)]
        public string Password { get; set; } = string.Empty;

        [Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [EmailAddress, MaxLength(64)]
        public string Email { get; set; } = string.Empty;
    }
}
