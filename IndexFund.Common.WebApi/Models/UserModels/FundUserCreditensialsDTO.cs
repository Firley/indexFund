using System.ComponentModel.DataAnnotations;

namespace IndexFund.Common.WebApi.Models
{
    public class FundUserCreditensialsDTO
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(6)]
        public string Password { get; set; }
    }
}
